-- TestingClaude Database
-- Import via phpMyAdmin: http://localhost/phpmyadmin

CREATE DATABASE IF NOT EXISTS `testingclaude` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

USE `testingclaude`;

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
