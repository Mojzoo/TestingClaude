-- TestingClaude Database
-- Import via phpMyAdmin: http://localhost/phpmyadmin

CREATE DATABASE IF NOT EXISTS `testingclaude` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

USE `testingclaude`;

-- Users table
CREATE TABLE IF NOT EXISTS `users` (
  `id`         INT(11)      NOT NULL AUTO_INCREMENT,
  `username`   VARCHAR(50)  NOT NULL,
  `email`      VARCHAR(100) NOT NULL,
  `password`   VARCHAR(64)  NOT NULL COMMENT 'SHA-256 hashed',
  `role`       VARCHAR(10)  NOT NULL DEFAULT 'user' COMMENT 'user or admin',
  `created_at` TIMESTAMP    NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `uq_username` (`username`),
  UNIQUE KEY `uq_email`    (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Password reset OTP table
CREATE TABLE IF NOT EXISTS `password_resets` (
  `id`         INT(11)     NOT NULL AUTO_INCREMENT,
  `email`      VARCHAR(100) NOT NULL,
  `otp_code`   VARCHAR(6)  NOT NULL,
  `created_at` TIMESTAMP   NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `used`       TINYINT(1)  NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`),
  KEY `idx_email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Rooms table
CREATE TABLE IF NOT EXISTS `rooms` (
  `id`              INT(11)        NOT NULL AUTO_INCREMENT,
  `room_number`     VARCHAR(10)    NOT NULL,
  `room_type`       VARCHAR(50)    NOT NULL,
  `description`     VARCHAR(255)   DEFAULT NULL,
  `price_per_night` DECIMAL(10,2)  NOT NULL,
  `capacity`        INT(11)        NOT NULL DEFAULT 2,
  `is_available`    TINYINT(1)     NOT NULL DEFAULT 1,
  PRIMARY KEY (`id`),
  UNIQUE KEY `uq_room_number` (`room_number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Bookings table
CREATE TABLE IF NOT EXISTS `bookings` (
  `id`          INT(11)        NOT NULL AUTO_INCREMENT,
  `user_id`     INT(11)        NOT NULL,
  `room_id`     INT(11)        NOT NULL,
  `check_in`    DATE           NOT NULL,
  `check_out`   DATE           NOT NULL,
  `total_price` DECIMAL(10,2)  NOT NULL,
  `status`      VARCHAR(20)    NOT NULL DEFAULT 'Confirmed',
  `created_at`  TIMESTAMP      NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_bookings_user` (`user_id`),
  KEY `fk_bookings_room` (`room_id`),
  CONSTRAINT `fk_bookings_user` FOREIGN KEY (`user_id`) REFERENCES `users`(`id`) ON DELETE CASCADE,
  CONSTRAINT `fk_bookings_room` FOREIGN KEY (`room_id`) REFERENCES `rooms`(`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Sample rooms (safe to re-run)
INSERT INTO `rooms` (`room_number`, `room_type`, `description`, `price_per_night`, `capacity`)
VALUES
  ('101', 'Standard', 'Cozy room with city view', 49.99, 2),
  ('102', 'Standard', 'Cozy room with garden view', 49.99, 2),
  ('201', 'Deluxe', 'Spacious room with king bed', 79.99, 2),
  ('202', 'Deluxe', 'Spacious room with private balcony', 79.99, 3),
  ('301', 'Suite', 'Luxury suite with living area', 129.99, 4),
  ('302', 'Suite', 'Penthouse suite with skyline view', 199.99, 4)
ON DUPLICATE KEY UPDATE room_type = VALUES(room_type);

-- To make an existing user an admin, run:
-- UPDATE users SET role='admin' WHERE username='your_username';
