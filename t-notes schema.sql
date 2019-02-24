-- MySQL Script generated by MySQL Workbench
-- Mon Feb 11 20:33:06 2019
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema t-notes
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema t-notes
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `t-notes` DEFAULT CHARACTER SET utf8 ;
USE `t-notes` ;

-- -----------------------------------------------------
-- Table `t-notes`.`User`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `t-notes`.`User` (
  `user_id` INT NOT NULL,
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `first_name` VARCHAR(45) NULL,
  `last_name` VARCHAR(45) NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `t-notes`.`Course`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `t-notes`.`Course` (
  `course_id` INT NOT NULL,
  `course_name` VARCHAR(45) NULL,
  `user_id` INT NOT NULL ,
  `subject` VARCHAR(45) NULL,
  `prof` VARCHAR(45) NULL,
  `semester` VARCHAR(45) NULL,
  `year` INT NULL,
  PRIMARY KEY (`course_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `t-notes`.`Note`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `t-notes`.`Note` (
  `note_id` INT NOT NULL,
  `note_title` VARCHAR(45) NULL,
  `course_id` INT NOT NULL,
  `chapter` INT NULL,
  `Section` INT NULL,
  `Summary` VARCHAR(1000) NULL,
  `keyword_id` INT NULL,
  `Date` DATE NOT NULL,
  `notes` BLOB NOT NULL,
  PRIMARY KEY (`note_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `t-notes`.`Keyword`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `t-notes`.`Keyword` (
  `keyword_id` INT NOT NULL,
  `key_one` VARCHAR(45) NULL,
  `key_two` VARCHAR(45) NULL,
  `key_three` VARCHAR(45) NULL,
  `key_four` VARCHAR(45)  NULL,
  `key_five` VARCHAR(45) NULL,
  PRIMARY KEY (`keyword_id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;