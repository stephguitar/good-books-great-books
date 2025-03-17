-- MySQL dump 10.13  Distrib 8.0.41, for Linux (x86_64)
--
-- Host: localhost    Database: LibraryDB
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `book_copies`
--

DROP TABLE IF EXISTS `book_copies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `book_copies` (
  `copy_id` varchar(15) NOT NULL,
  `book_id` varchar(10) DEFAULT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'available',
  PRIMARY KEY (`copy_id`),
  KEY `book_id` (`book_id`),
  CONSTRAINT `book_copies_ibfk_1` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`),
  CONSTRAINT `chk_book_copies_status` CHECK (`status` in ('available','not available'))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book_copies`
--

LOCK TABLES `book_copies` WRITE;
/*!40000 ALTER TABLE `book_copies` DISABLE KEYS */;
INSERT INTO `book_copies` VALUES ('BK-0001-01','BK-0001','not available'),('BK-0001-02','BK-0001','available'),('BK-0001-03','BK-0001','available'),('BK-0001-04','BK-0001','available'),('BK-0001-05','BK-0001','available'),('BK-0002-01','BK-0002','available'),('BK-0002-02','BK-0002','available'),('BK-0002-03','BK-0002','available'),('BK-0002-04','BK-0002','available'),('BK-0002-05','BK-0002','not available'),('BK-0003-01','BK-0003','available'),('BK-0003-02','BK-0003','available'),('BK-0003-03','BK-0003','available'),('BK-0003-04','BK-0003','available'),('BK-0003-05','BK-0003','available'),('BK-0004-01','BK-0004','available'),('BK-0004-02','BK-0004','available'),('BK-0004-03','BK-0004','available'),('BK-0004-04','BK-0004','available'),('BK-0004-05','BK-0004','available'),('BK-0005-01','BK-0005','available'),('BK-0005-02','BK-0005','available'),('BK-0005-03','BK-0005','available'),('BK-0005-04','BK-0005','available'),('BK-0005-05','BK-0005','available'),('BK-0006-01','BK-0006','available'),('BK-0006-02','BK-0006','available'),('BK-0006-03','BK-0006','available'),('BK-0006-04','BK-0006','available'),('BK-0006-05','BK-0006','available'),('BK-0007-01','BK-0007','available'),('BK-0007-02','BK-0007','available'),('BK-0007-03','BK-0007','available'),('BK-0007-04','BK-0007','available'),('BK-0007-05','BK-0007','available'),('BK-0008-01','BK-0008','available'),('BK-0008-02','BK-0008','available'),('BK-0008-03','BK-0008','available'),('BK-0008-04','BK-0008','available'),('BK-0008-05','BK-0008','available'),('BK-0009-01','BK-0009','available'),('BK-0009-02','BK-0009','available'),('BK-0009-03','BK-0009','available'),('BK-0009-04','BK-0009','available'),('BK-0009-05','BK-0009','available');
/*!40000 ALTER TABLE `book_copies` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER update_book_status
AFTER UPDATE ON book_copies
FOR EACH ROW
BEGIN
    DECLARE available_count INT;

    -- Ensure book_id is not NULL
    IF NEW.book_id IS NOT NULL THEN
        -- Count how many copies of the book are still available
        SELECT COUNT(*) INTO available_count
        FROM book_copies
        WHERE book_id = NEW.book_id AND status = 'available';

        -- Update books table status
        IF available_count = 0 THEN
            UPDATE books SET status = 'not available' WHERE book_id = NEW.book_id;
        ELSE
            UPDATE books SET status = 'available' WHERE book_id = NEW.book_id;
        END IF;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `books` (
  `book_id` varchar(10) NOT NULL,
  `title` varchar(255) DEFAULT NULL,
  `author` varchar(255) DEFAULT NULL,
  `isbn` varchar(20) DEFAULT NULL,
  `publisher` varchar(255) DEFAULT NULL,
  `edition` varchar(50) DEFAULT NULL,
  `genre` varchar(50) DEFAULT NULL,
  `status` varchar(20) DEFAULT 'available',
  `borrow_counter` int(11) DEFAULT 0,
  PRIMARY KEY (`book_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES ('BK-0001','Harry Potter and the Philosopher\'s Stone','J.K. Rowling','978-1-4088-5589-8','Bloomsbury Publishing','1st','Fantasy','Available',0),('BK-0002','Harry Potter and the Chamber of Secrets','J.K. Rowling','978-1-4088-5590-4','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0003','Harry Potter and the Prisoner of Azkaban','J.K. Rowling','978-1-4088-5591-1','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0004','Harry Potter and the Goblet of Fire','J.K. Rowling','978-1-4088-5592-8','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0005','Harry Potter and the Order of the Phoenix','J.K. Rowling','978-1-4088-5593-5','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0006','Harry Potter and the Half-Blood Prince','J.K. Rowling','978-1-4088-5594-2','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0007','Harry Potter and the Deathly Hallows Part 1','J.K. Rowling','978-1-4088-5595-9','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0008','Harry Potter and the Deathly Hallows Part 2','J.K. Rowling','978-1-4088-5596-6','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0009','Harry Potter and the Cursed Child','J.K. Rowling','978-0-7515-6536-2','Little, Brown','1st','Fantasy','available',0);
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `borrow`
--

DROP TABLE IF EXISTS `borrow`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `borrow` (
  `transaction_id` varchar(50) NOT NULL,
  `copy_id` varchar(15) NOT NULL,
  `book_id` varchar(10) NOT NULL,
  `librarian_id` varchar(11) NOT NULL,
  `member_id` varchar(10) NOT NULL,
  `issue_date` date NOT NULL,
  `due_date` date NOT NULL,
  `return_date` date DEFAULT NULL,
  PRIMARY KEY (`transaction_id`),
  KEY `copy_id` (`copy_id`),
  KEY `book_id` (`book_id`),
  KEY `librarian_id` (`librarian_id`),
  KEY `member_id` (`member_id`),
  CONSTRAINT `borrow_ibfk_1` FOREIGN KEY (`copy_id`) REFERENCES `book_copies` (`copy_id`),
  CONSTRAINT `borrow_ibfk_2` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`),
  CONSTRAINT `borrow_ibfk_3` FOREIGN KEY (`librarian_id`) REFERENCES `librarian` (`librarian_id`),
  CONSTRAINT `borrow_ibfk_4` FOREIGN KEY (`member_id`) REFERENCES `members` (`member_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `borrow`
--

LOCK TABLES `borrow` WRITE;
/*!40000 ALTER TABLE `borrow` DISABLE KEYS */;
INSERT INTO `borrow` VALUES ('TXN-20250317210008','BK-0001-01','BK-0001','LIB0001','MEM0001','2025-03-17','2025-03-20',NULL);
/*!40000 ALTER TABLE `borrow` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fines`
--

DROP TABLE IF EXISTS `fines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fines` (
  `fine_id` int(11) NOT NULL AUTO_INCREMENT,
  `transaction_id` varchar(50) NOT NULL,
  `member_id` varchar(10) NOT NULL,
  `book_id` varchar(10) NOT NULL,
  `copy_id` varchar(15) NOT NULL,
  `fine_amount` decimal(10,2) NOT NULL DEFAULT 0.00,
  `paid` tinyint(1) NOT NULL DEFAULT 0,
  `paid_date` date DEFAULT NULL,
  PRIMARY KEY (`fine_id`),
  KEY `transaction_id` (`transaction_id`),
  KEY `member_id` (`member_id`),
  KEY `book_id` (`book_id`),
  KEY `copy_id` (`copy_id`),
  CONSTRAINT `fines_ibfk_1` FOREIGN KEY (`transaction_id`) REFERENCES `borrow` (`transaction_id`),
  CONSTRAINT `fines_ibfk_2` FOREIGN KEY (`member_id`) REFERENCES `members` (`member_id`),
  CONSTRAINT `fines_ibfk_3` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`),
  CONSTRAINT `fines_ibfk_4` FOREIGN KEY (`copy_id`) REFERENCES `book_copies` (`copy_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fines`
--

LOCK TABLES `fines` WRITE;
/*!40000 ALTER TABLE `fines` DISABLE KEYS */;
/*!40000 ALTER TABLE `fines` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `librarian`
--

DROP TABLE IF EXISTS `librarian`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `librarian` (
  `librarian_id` varchar(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(20) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) DEFAULT NULL,
  `phone` varchar(15) DEFAULT NULL,
  `address` varchar(100) NOT NULL,
  `position` varchar(50) NOT NULL,
  PRIMARY KEY (`librarian_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `librarian`
--

LOCK TABLES `librarian` WRITE;
/*!40000 ALTER TABLE `librarian` DISABLE KEYS */;
INSERT INTO `librarian` VALUES ('LIB0001','','admin','admin','admin','admin','09347281921','','Library Manager'),('LIB0002','test','test','test','test','test','test232t','test','Library Assistant');
/*!40000 ALTER TABLE `librarian` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `members`
--

DROP TABLE IF EXISTS `members`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `members` (
  `member_id` varchar(10) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) DEFAULT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `address` text DEFAULT NULL,
  `membership_type` varchar(20) NOT NULL,
  `borrow_counter` int(11) DEFAULT NULL,
  PRIMARY KEY (`member_id`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `members`
--

LOCK TABLES `members` WRITE;
/*!40000 ALTER TABLE `members` DISABLE KEYS */;
INSERT INTO `members` VALUES ('MEM0001','test','test','test','test','test','test','test','Regular',NULL);
/*!40000 ALTER TABLE `members` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER before_insert_members
BEFORE INSERT ON members
FOR EACH ROW
BEGIN
    DECLARE next_id INT;
    DECLARE formatted_id VARCHAR(10);
    
    -- Get the next sequential number
    SELECT IFNULL(MAX(CAST(SUBSTRING(member_id, 4, 4) AS UNSIGNED)), 0) + 1 INTO next_id FROM members;
    
    -- Format it as MEM0001, MEM0002, etc.
    SET formatted_id = CONCAT('MEM', LPAD(next_id, 4, '0'));
    
    -- Assign it to the new row
    SET NEW.member_id = formatted_id;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `reservations`
--

DROP TABLE IF EXISTS `reservations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservations` (
  `reservation_id` varchar(50) NOT NULL,
  `book_id` varchar(10) NOT NULL,
  `copy_id` varchar(15) NOT NULL,
  `member_id` varchar(10) NOT NULL,
  `librarian_id` varchar(11) NOT NULL,
  `reserve_date` date NOT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'Pending',
  `notified` tinyint(1) DEFAULT 0,
  `expires_at` date DEFAULT NULL,
  PRIMARY KEY (`reservation_id`),
  KEY `book_id` (`book_id`),
  KEY `copy_id` (`copy_id`),
  KEY `member_id` (`member_id`),
  KEY `librarian_id` (`librarian_id`),
  CONSTRAINT `reservations_ibfk_1` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`),
  CONSTRAINT `reservations_ibfk_2` FOREIGN KEY (`copy_id`) REFERENCES `book_copies` (`copy_id`),
  CONSTRAINT `reservations_ibfk_3` FOREIGN KEY (`member_id`) REFERENCES `members` (`member_id`),
  CONSTRAINT `reservations_ibfk_4` FOREIGN KEY (`librarian_id`) REFERENCES `librarian` (`librarian_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservations`
--

LOCK TABLES `reservations` WRITE;
/*!40000 ALTER TABLE `reservations` DISABLE KEYS */;
/*!40000 ALTER TABLE `reservations` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-03-18  5:56:41
