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
