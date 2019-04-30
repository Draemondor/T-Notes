-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: t-notes
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `course`
--

DROP TABLE IF EXISTS `course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `course` (
  `course_id` int(11) NOT NULL,
  `course_name` varchar(45) DEFAULT NULL,
  `subject` varchar(45) DEFAULT NULL,
  `prof` varchar(45) DEFAULT NULL,
  `semester` varchar(45) DEFAULT NULL,
  `year` int(11) DEFAULT NULL,
  PRIMARY KEY (`course_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `course`
--

LOCK TABLES `course` WRITE;
/*!40000 ALTER TABLE `course` DISABLE KEYS */;
INSERT INTO `course` VALUES (36157,'Programming Fundamentals IV','Computer Science','Thomas Jefferson','Winter',2419),(36248,'Programming Fundamentals III','Computer Science','Jared Camren','Spring',2159),(39248,'Programming Fundamentals V','Computer Science','Donald Trump','Fall',2619),(40686,'Programming Fundamentals III','Computer Science','Jared Camren','Spring',2119),(41686,'Programming Fundamentals III','Computer Science','Jill James','Spring',2119),(42686,'Programming Fundamentals IV','Computer Science','Bob James','Spring',2119),(43686,'Programming Fundamentals IV','Computer Science','Thomas Jefferson','Spring',2119),(44686,'Programming Fundamentals V','Computer Science','George Washington','Spring',2119),(45586,'Programming Fundamentals V','Computer Science','Donald Trump','Spring',2119),(45686,'Programming Fundamentals I','Computer Science','Scarlett Joehannson','Spring',2119),(46686,'Programming Fundamentals I','Computer Science','Scarlett Joehannson','Spring',2119),(47686,'Programming Fundamentals I','Computer Science','Bruce Wayne','Spring',2119),(48686,'Programming Fundamentals II','Computer Science','Kyle Burris','Spring',2119),(49686,'Programming Fundamentals II','Computer Science','Jack Black','Spring',2119),(50686,'Programming Fundamentals III','Computer Science','Jared Camren','Fall',2119),(51686,'Programming Fundamentals III','Computer Science','Jill James','Fall',2119),(52686,'Programming Fundamentals IV','Computer Science','Bob James','Fall',2119),(53686,'Programming Fundamentals IV','Computer Science','Thomas Jefferson','Fall',2119),(54686,'Programming Fundamentals V','Computer Science','George Washington','Fall',2119),(55586,'Programming Fundamentals V','Computer Science','Donald Trump','Fall',2119),(56686,'Programming Fundamentals I','Computer Science','Scarlett Joehannson','Fall',2119),(57686,'Programming Fundamentals I','Computer Science','Bruce Wayne','Fall',2119),(58686,'Programming Fundamentals II','Computer Science','Kyle Burris','Fall',2119),(59463,'Programming Fundamentals II','Computer Science','Kyle Burris','Summer',2139),(59686,'Programming Fundamentals II','Computer Science','Jack Black','Fall',2119),(59874,'Programming Fundamentals II','Computer Science','Jack Black','Winter',2149),(65157,'Programming Fundamentals IV','Computer Science','Bob James','Summer',2319),(82427,'Programming Fundamentals I','Computer Science','Bruce Wayne','Fall',2129),(97518,'Programming Fundamentals V','Computer Science','George Washington','Spring',2519),(97845,'Programming Fundamentals III','Computer Science','Jill James','Fall',2219);
/*!40000 ALTER TABLE `course` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-04-27  0:41:28
