-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema pointofsalesdb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema pointofsalesdb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `pointofsalesdb` ;
USE `pointofsalesdb` ;

-- -----------------------------------------------------
-- Table `pointofsalesdb`.`coffee`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pointofsalesdb`.`coffee` (
  `idx` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `quantity` INT NULL DEFAULT '0',
  `price` INT NULL DEFAULT NULL,
  PRIMARY KEY (`idx`),
  UNIQUE INDEX `idx_UNIQUE` (`idx` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 14;


-- -----------------------------------------------------
-- Table `pointofsalesdb`.`desert`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pointofsalesdb`.`desert` (
  `idx` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) CHARACTER SET 'utf8mb3' NOT NULL,
  `quantity` INT NULL DEFAULT '0',
  `price` INT NULL DEFAULT NULL,
  PRIMARY KEY (`idx`),
  UNIQUE INDEX `idx_UNIQUE` (`idx` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 13;


-- -----------------------------------------------------
-- Table `pointofsalesdb`.`tea`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pointofsalesdb`.`tea` (
  `idx` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) COLLATE 'utf8mb3_bin' NOT NULL,
  `price` INT NULL DEFAULT NULL,
  `quantity` INT NULL DEFAULT '0',
  PRIMARY KEY (`idx`),
  UNIQUE INDEX `idx_UNIQUE` (`idx` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 5;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
