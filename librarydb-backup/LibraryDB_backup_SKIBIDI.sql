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
INSERT INTO `book_copies` VALUES ('BK-0001-01','BK-0001','not available'),('BK-0001-02','BK-0001','available'),('BK-0001-03','BK-0001','available'),('BK-0001-04','BK-0001','available'),('BK-0001-05','BK-0001','available'),('BK-0002-01','BK-0002','available'),('BK-0002-02','BK-0002','available'),('BK-0002-03','BK-0002','available'),('BK-0002-04','BK-0002','available'),('BK-0002-05','BK-0002','not available'),('BK-0003-01','BK-0003','available'),('BK-0003-02','BK-0003','available'),('BK-0003-03','BK-0003','available'),('BK-0003-04','BK-0003','available'),('BK-0003-05','BK-0003','available'),('BK-0004-01','BK-0004','available'),('BK-0004-02','BK-0004','available'),('BK-0004-03','BK-0004','available'),('BK-0004-04','BK-0004','available'),('BK-0004-05','BK-0004','available'),('BK-0005-01','BK-0005','available'),('BK-0005-02','BK-0005','available'),('BK-0005-03','BK-0005','available'),('BK-0005-04','BK-0005','available'),('BK-0005-05','BK-0005','available'),('BK-0006-01','BK-0006','available'),('BK-0006-02','BK-0006','available'),('BK-0006-03','BK-0006','available'),('BK-0006-04','BK-0006','available'),('BK-0006-05','BK-0006','available'),('BK-0007-01','BK-0007','available'),('BK-0007-02','BK-0007','available'),('BK-0007-03','BK-0007','available'),('BK-0007-04','BK-0007','available'),('BK-0007-05','BK-0007','available'),('BK-0008-01','BK-0008','available'),('BK-0008-02','BK-0008','available'),('BK-0008-03','BK-0008','available'),('BK-0008-04','BK-0008','available'),('BK-0008-05','BK-0008','available'),('BK-0009-01','BK-0009','available'),('BK-0009-02','BK-0009','available'),('BK-0009-03','BK-0009','available'),('BK-0009-04','BK-0009','available'),('BK-0009-05','BK-0009','available'),('BK-0010-01','BK-0010','available'),('BK-0010-02','BK-0010','available'),('BK-0010-03','BK-0010','available'),('BK-0010-04','BK-0010','available'),('BK-0010-05','BK-0010','available'),('BK-0011-01','BK-0011','available'),('BK-0011-02','BK-0011','available'),('BK-0011-03','BK-0011','available'),('BK-0011-04','BK-0011','available'),('BK-0011-05','BK-0011','available'),('BK-0012-01','BK-0012','available'),('BK-0012-02','BK-0012','available'),('BK-0012-03','BK-0012','available'),('BK-0012-04','BK-0012','available'),('BK-0012-05','BK-0012','available'),('BK-0013-01','BK-0013','available'),('BK-0013-02','BK-0013','available'),('BK-0013-03','BK-0013','available'),('BK-0013-04','BK-0013','available'),('BK-0013-05','BK-0013','available'),('BK-0014-01','BK-0014','available'),('BK-0014-02','BK-0014','available'),('BK-0014-03','BK-0014','available'),('BK-0014-04','BK-0014','available'),('BK-0014-05','BK-0014','available'),('BK-0015-01','BK-0015','available'),('BK-0015-02','BK-0015','available'),('BK-0015-03','BK-0015','available'),('BK-0015-04','BK-0015','available'),('BK-0015-05','BK-0015','available'),('BK-0016-01','BK-0016','available'),('BK-0016-02','BK-0016','available'),('BK-0016-03','BK-0016','available'),('BK-0016-04','BK-0016','available'),('BK-0016-05','BK-0016','available'),('BK-0017-01','BK-0017','available'),('BK-0017-02','BK-0017','available'),('BK-0017-03','BK-0017','available'),('BK-0017-04','BK-0017','available'),('BK-0017-05','BK-0017','available'),('BK-0018-01','BK-0018','available'),('BK-0018-02','BK-0018','available'),('BK-0018-03','BK-0018','available'),('BK-0018-04','BK-0018','available'),('BK-0018-05','BK-0018','available'),('BK-0019-01','BK-0019','available'),('BK-0019-02','BK-0019','available'),('BK-0019-03','BK-0019','available'),('BK-0019-04','BK-0019','available'),('BK-0019-05','BK-0019','available'),('BK-0020-01','BK-0020','available'),('BK-0020-02','BK-0020','available'),('BK-0020-03','BK-0020','available'),('BK-0020-04','BK-0020','available'),('BK-0020-05','BK-0020','available'),('BK-0021-01','BK-0021','available'),('BK-0021-02','BK-0021','available'),('BK-0021-03','BK-0021','available'),('BK-0021-04','BK-0021','available'),('BK-0021-05','BK-0021','available'),('BK-0022-01','BK-0022','available'),('BK-0022-02','BK-0022','available'),('BK-0022-03','BK-0022','available'),('BK-0022-04','BK-0022','available'),('BK-0022-05','BK-0022','available'),('BK-0023-01','BK-0023','available'),('BK-0023-02','BK-0023','available'),('BK-0023-03','BK-0023','available'),('BK-0023-04','BK-0023','available'),('BK-0023-05','BK-0023','available'),('BK-0024-01','BK-0024','available'),('BK-0024-02','BK-0024','available'),('BK-0024-03','BK-0024','available'),('BK-0024-04','BK-0024','available'),('BK-0024-05','BK-0024','available'),('BK-0025-01','BK-0025','available'),('BK-0025-02','BK-0025','available'),('BK-0025-03','BK-0025','available'),('BK-0025-04','BK-0025','available'),('BK-0025-05','BK-0025','available'),('BK-0026-01','BK-0026','available'),('BK-0026-02','BK-0026','available'),('BK-0026-03','BK-0026','available'),('BK-0026-04','BK-0026','available'),('BK-0026-05','BK-0026','available'),('BK-0027-01','BK-0027','available'),('BK-0027-02','BK-0027','available'),('BK-0027-03','BK-0027','available'),('BK-0027-04','BK-0027','available'),('BK-0027-05','BK-0027','available'),('BK-0028-01','BK-0028','available'),('BK-0028-02','BK-0028','available'),('BK-0028-03','BK-0028','available'),('BK-0028-04','BK-0028','available'),('BK-0028-05','BK-0028','available'),('BK-0029-01','BK-0029','available'),('BK-0029-02','BK-0029','available'),('BK-0029-03','BK-0029','available'),('BK-0029-04','BK-0029','available'),('BK-0029-05','BK-0029','available'),('BK-0030-01','BK-0030','available'),('BK-0030-02','BK-0030','available'),('BK-0030-03','BK-0030','available'),('BK-0030-04','BK-0030','available'),('BK-0030-05','BK-0030','available'),('BK-0031-01','BK-0031','available'),('BK-0031-02','BK-0031','available'),('BK-0031-03','BK-0031','available'),('BK-0031-04','BK-0031','available'),('BK-0031-05','BK-0031','available'),('BK-0032-01','BK-0032','available'),('BK-0032-02','BK-0032','available'),('BK-0032-03','BK-0032','available'),('BK-0032-04','BK-0032','available'),('BK-0032-05','BK-0032','available'),('BK-0033-01','BK-0033','available'),('BK-0033-02','BK-0033','available'),('BK-0033-03','BK-0033','available'),('BK-0033-04','BK-0033','available'),('BK-0033-05','BK-0033','available'),('BK-0034-01','BK-0034','available'),('BK-0034-02','BK-0034','available'),('BK-0034-03','BK-0034','available'),('BK-0034-04','BK-0034','available'),('BK-0034-05','BK-0034','available'),('BK-0035-01','BK-0035','available'),('BK-0035-02','BK-0035','available'),('BK-0035-03','BK-0035','available'),('BK-0035-04','BK-0035','available'),('BK-0035-05','BK-0035','available'),('BK-0036-01','BK-0036','available'),('BK-0036-02','BK-0036','available'),('BK-0036-03','BK-0036','available'),('BK-0036-04','BK-0036','available'),('BK-0036-05','BK-0036','available'),('BK-0037-01','BK-0037','available'),('BK-0037-02','BK-0037','available'),('BK-0037-03','BK-0037','available'),('BK-0037-04','BK-0037','available'),('BK-0037-05','BK-0037','available'),('BK-0038-01','BK-0038','available'),('BK-0038-02','BK-0038','available'),('BK-0038-03','BK-0038','available'),('BK-0038-04','BK-0038','available'),('BK-0038-05','BK-0038','available'),('BK-0039-01','BK-0039','available'),('BK-0039-02','BK-0039','available'),('BK-0039-03','BK-0039','available'),('BK-0039-04','BK-0039','available'),('BK-0039-05','BK-0039','available'),('BK-0040-01','BK-0040','available'),('BK-0040-02','BK-0040','available'),('BK-0040-03','BK-0040','available'),('BK-0040-04','BK-0040','available'),('BK-0040-05','BK-0040','available'),('BK-0041-01','BK-0041','available'),('BK-0041-02','BK-0041','available'),('BK-0041-03','BK-0041','available'),('BK-0041-04','BK-0041','available'),('BK-0041-05','BK-0041','available'),('BK-0042-01','BK-0042','available'),('BK-0042-02','BK-0042','available'),('BK-0042-03','BK-0042','available'),('BK-0042-04','BK-0042','available'),('BK-0042-05','BK-0042','available'),('BK-0043-01','BK-0043','available'),('BK-0043-02','BK-0043','available'),('BK-0043-03','BK-0043','available'),('BK-0043-04','BK-0043','available'),('BK-0043-05','BK-0043','available'),('BK-0044-01','BK-0044','available'),('BK-0044-02','BK-0044','available'),('BK-0044-03','BK-0044','available'),('BK-0044-04','BK-0044','available'),('BK-0044-05','BK-0044','available'),('BK-0045-01','BK-0045','available'),('BK-0045-02','BK-0045','available'),('BK-0045-03','BK-0045','available'),('BK-0045-04','BK-0045','available'),('BK-0045-05','BK-0045','available'),('BK-0046-01','BK-0046','available'),('BK-0046-02','BK-0046','available'),('BK-0046-03','BK-0046','available'),('BK-0046-04','BK-0046','available'),('BK-0046-05','BK-0046','available'),('BK-0047-01','BK-0047','available'),('BK-0047-02','BK-0047','available'),('BK-0047-03','BK-0047','available'),('BK-0047-04','BK-0047','available'),('BK-0047-05','BK-0047','available'),('BK-0048-01','BK-0048','available'),('BK-0048-02','BK-0048','available'),('BK-0048-03','BK-0048','available'),('BK-0048-04','BK-0048','available'),('BK-0048-05','BK-0048','available'),('BK-0049-01','BK-0049','available'),('BK-0049-02','BK-0049','available'),('BK-0049-03','BK-0049','available'),('BK-0049-04','BK-0049','available'),('BK-0049-05','BK-0049','available'),('BK-0050-01','BK-0050','available'),('BK-0050-02','BK-0050','available'),('BK-0050-03','BK-0050','available'),('BK-0050-04','BK-0050','available'),('BK-0050-05','BK-0050','available'),('BK-0051-01','BK-0051','available'),('BK-0051-02','BK-0051','available'),('BK-0051-03','BK-0051','available'),('BK-0051-04','BK-0051','available'),('BK-0051-05','BK-0051','available'),('BK-0052-01','BK-0052','available'),('BK-0052-02','BK-0052','available'),('BK-0052-03','BK-0052','available'),('BK-0052-04','BK-0052','available'),('BK-0052-05','BK-0052','available'),('BK-0053-01','BK-0053','available'),('BK-0053-02','BK-0053','available'),('BK-0053-03','BK-0053','available'),('BK-0053-04','BK-0053','available'),('BK-0053-05','BK-0053','available'),('BK-0054-01','BK-0054','available'),('BK-0054-02','BK-0054','available'),('BK-0054-03','BK-0054','available'),('BK-0054-04','BK-0054','available'),('BK-0054-05','BK-0054','available'),('BK-0055-01','BK-0055','available'),('BK-0055-02','BK-0055','available'),('BK-0055-03','BK-0055','available'),('BK-0055-04','BK-0055','available'),('BK-0055-05','BK-0055','available'),('BK-0056-01','BK-0056','available'),('BK-0056-02','BK-0056','available'),('BK-0056-03','BK-0056','available'),('BK-0056-04','BK-0056','available'),('BK-0056-05','BK-0056','available'),('BK-0057-01','BK-0057','available'),('BK-0057-02','BK-0057','available'),('BK-0057-03','BK-0057','available'),('BK-0057-04','BK-0057','available'),('BK-0057-05','BK-0057','available'),('BK-0058-01','BK-0058','available'),('BK-0058-02','BK-0058','available'),('BK-0058-03','BK-0058','available'),('BK-0058-04','BK-0058','available'),('BK-0058-05','BK-0058','available'),('BK-0059-01','BK-0059','available'),('BK-0059-02','BK-0059','available'),('BK-0059-03','BK-0059','available'),('BK-0059-04','BK-0059','available'),('BK-0059-05','BK-0059','available'),('BK-0060-01','BK-0060','available'),('BK-0060-02','BK-0060','available'),('BK-0060-03','BK-0060','available'),('BK-0060-04','BK-0060','available'),('BK-0060-05','BK-0060','available'),('BK-0061-01','BK-0061','available'),('BK-0061-02','BK-0061','available'),('BK-0061-03','BK-0061','available'),('BK-0061-04','BK-0061','available'),('BK-0061-05','BK-0061','available'),('BK-0062-01','BK-0062','available'),('BK-0062-02','BK-0062','available'),('BK-0062-03','BK-0062','available'),('BK-0062-04','BK-0062','available'),('BK-0062-05','BK-0062','available'),('BK-0063-01','BK-0063','available'),('BK-0063-02','BK-0063','available'),('BK-0063-03','BK-0063','available'),('BK-0063-04','BK-0063','available'),('BK-0063-05','BK-0063','available'),('BK-0064-01','BK-0064','available'),('BK-0064-02','BK-0064','available'),('BK-0064-03','BK-0064','available'),('BK-0064-04','BK-0064','available'),('BK-0064-05','BK-0064','available'),('BK-0065-01','BK-0065','available'),('BK-0065-02','BK-0065','available'),('BK-0065-03','BK-0065','available'),('BK-0065-04','BK-0065','available'),('BK-0065-05','BK-0065','available'),('BK-0066-01','BK-0066','available'),('BK-0066-02','BK-0066','available'),('BK-0066-03','BK-0066','available'),('BK-0066-04','BK-0066','available'),('BK-0066-05','BK-0066','available'),('BK-0067-01','BK-0067','available'),('BK-0067-02','BK-0067','available'),('BK-0067-03','BK-0067','available'),('BK-0067-04','BK-0067','available'),('BK-0067-05','BK-0067','available'),('BK-0068-01','BK-0068','available'),('BK-0068-02','BK-0068','available'),('BK-0068-03','BK-0068','available'),('BK-0068-04','BK-0068','available'),('BK-0068-05','BK-0068','available'),('BK-0069-01','BK-0069','available'),('BK-0069-02','BK-0069','available'),('BK-0069-03','BK-0069','available'),('BK-0069-04','BK-0069','available'),('BK-0069-05','BK-0069','available'),('BK-0070-01','BK-0070','available'),('BK-0070-02','BK-0070','available'),('BK-0070-03','BK-0070','available'),('BK-0070-04','BK-0070','available'),('BK-0070-05','BK-0070','available'),('BK-0071-01','BK-0071','available'),('BK-0071-02','BK-0071','available'),('BK-0071-03','BK-0071','available'),('BK-0071-04','BK-0071','available'),('BK-0071-05','BK-0071','available'),('BK-0072-01','BK-0072','available'),('BK-0072-02','BK-0072','available'),('BK-0072-03','BK-0072','available'),('BK-0072-04','BK-0072','available'),('BK-0072-05','BK-0072','available'),('BK-0073-01','BK-0073','available'),('BK-0073-02','BK-0073','available'),('BK-0073-03','BK-0073','available'),('BK-0073-04','BK-0073','available'),('BK-0073-05','BK-0073','available'),('BK-0074-01','BK-0074','available'),('BK-0074-02','BK-0074','available'),('BK-0074-03','BK-0074','available'),('BK-0074-04','BK-0074','available'),('BK-0074-05','BK-0074','available'),('BK-0075-01','BK-0075','available'),('BK-0075-02','BK-0075','available'),('BK-0075-03','BK-0075','available'),('BK-0075-04','BK-0075','available'),('BK-0075-05','BK-0075','available'),('BK-0076-01','BK-0076','available'),('BK-0076-02','BK-0076','available'),('BK-0076-03','BK-0076','available'),('BK-0076-04','BK-0076','available'),('BK-0076-05','BK-0076','available'),('BK-0077-01','BK-0077','available'),('BK-0077-02','BK-0077','available'),('BK-0077-03','BK-0077','available'),('BK-0077-04','BK-0077','available'),('BK-0077-05','BK-0077','available'),('BK-0078-01','BK-0078','available'),('BK-0078-02','BK-0078','available'),('BK-0078-03','BK-0078','available'),('BK-0078-04','BK-0078','available'),('BK-0078-05','BK-0078','available'),('BK-0079-01','BK-0079','available'),('BK-0079-02','BK-0079','available'),('BK-0079-03','BK-0079','available'),('BK-0079-04','BK-0079','available'),('BK-0079-05','BK-0079','available');
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
INSERT INTO `books` VALUES ('BK-0001','Harry Potter and the Philosopher\'s Stone','J.K. Rowling','978-1-4088-5589-8','Bloomsbury Publishing','1st','Fantasy','Available',0),('BK-0002','Harry Potter and the Chamber of Secrets','J.K. Rowling','978-1-4088-5590-4','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0003','Harry Potter and the Prisoner of Azkaban','J.K. Rowling','978-1-4088-5591-1','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0004','Harry Potter and the Goblet of Fire','J.K. Rowling','978-1-4088-5592-8','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0005','Harry Potter and the Order of the Phoenix','J.K. Rowling','978-1-4088-5593-5','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0006','Harry Potter and the Half-Blood Prince','J.K. Rowling','978-1-4088-5594-2','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0007','Harry Potter and the Deathly Hallows Part 1','J.K. Rowling','978-1-4088-5595-9','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0008','Harry Potter and the Deathly Hallows Part 2','J.K. Rowling','978-1-4088-5596-6','Bloomsbury Publishing','1st','Fantasy','available',0),('BK-0009','Harry Potter and the Cursed Child','J.K. Rowling','978-0-7515-6536-2','Little, Brown','1st','Fantasy','available',0),('BK-0010','The Chronicles of Narnia: The Lion, the Witch and the Wardrobe','C.S. Lewis','978-0-00-671677-8','HarperCollins','1st','Fantasy','available',0),('BK-0011','The Chronicles of Narnia: Prince Caspian','C.S. Lewis','978-0-00-671679-2','HarperCollins','1st','Fantasy','available',0),('BK-0012','The Chronicles of Narnia: The Voyage of the Dawn Treader','C.S. Lewis','978-0-00-671680-8','HarperCollins','1st','Fantasy','available',0),('BK-0013','The Chronicles of Narnia: The Silver Chair','C.S. Lewis','978-0-00-671681-5','HarperCollins','1st','Fantasy','available',0),('BK-0014','The Chronicles of Narnia: The Horse and His Boy','C.S. Lewis','978-0-00-671682-2','HarperCollins','1st','Fantasy','available',0),('BK-0015','The Chronicles of Narnia: The Magician\'s Nephew','C.S. Lewis','978-0-00-671683-9','HarperCollins','1st','Fantasy','available',0),('BK-0016','The Chronicles of Narnia: The Last Battle','C.S. Lewis','978-0-00-671684-6','HarperCollins','1st','Fantasy','available',0),('BK-0017','Divergent','Veronica Roth','978-0-06-202402-2','HarperCollins','1st','Science Fiction','available',0),('BK-0018','Insurgent','Veronica Roth','978-0-06-202404-6','HarperCollins','1st','Science Fiction','available',0),('BK-0019','Allegiant','Veronica Roth','978-0-06-202406-0','HarperCollins','1st','Science Fiction','available',0),('BK-0020','The Hunger Games','Suzanne Collins','978-0-439-02348-1','Scholastic','1st','Science Fiction','available',0),('BK-0021','The Hunger Games: Catching Fire','Suzanne Collins','978-0-439-02349-8','Scholastic','1st','Science Fiction','available',0),('BK-0022','The Hunger Games: The Mockingjay','Suzanne Collins','978-0-439-02350-4','Scholastic','1st','Science Fiction','available',0),('BK-0023','The Hunger Games: The Ballad of Songbirds and Snakes','Suzanne Collins','978-1-338-63517-1','Scholastic','1st','Science Fiction','available',0),('BK-0024','The Maze Runner','James Dashner','978-0-385-73799-7','Delacorte Press','1st','Science Fiction','available',0),('BK-0025','The Scorch Trials','James Dashner','978-0-385-73800-0','Delacorte Press','1st','Science Fiction','available',0),('BK-0026','The Death Cure','James Dashner','978-0-385-73801-7','Delacorte Press','1st','Science Fiction','available',0),('BK-0027','Percy Jackson and The Lightning Thief','Rick Riordan','978-0-7868-5629-9','Disney-Hyperion','1st','Fantasy','available',0),('BK-0028','Percy Jackson and The Sea of Monsters','Rick Riordan','978-0-7868-5686-2','Disney-Hyperion','1st','Fantasy','available',0),('BK-0029','Percy Jackson and The Titan\'s Curse','Rick Riordan','978-1-4231-0145-1','Disney-Hyperion','1st','Fantasy','available',0),('BK-0030','Percy Jackson and The Battle of the Labyrinth','Rick Riordan','978-1-4231-0146-8','Disney-Hyperion','1st','Fantasy','available',0),('BK-0031','Percy Jackson and The Last Olympian','Rick Riordan','978-1-4231-0147-5','Disney-Hyperion','1st','Fantasy','available',0),('BK-0032','Percy Jackson and The Chalice of the Gods','Rick Riordan','978-1-368-09054-9','Disney-Hyperion','1st','Fantasy','available',0),('BK-0033','Percy Jackson and The Wrath of the Triple Goddess','Rick Riordan',NULL,'Disney-Hyperion','Upcoming','Fantasy','available',0),('BK-0034','I Am Number Four','Pittacus Lore','978-0-06-196955-3','HarperCollins','1st','Science Fiction','available',0),('BK-0035','The Power of Six','Pittacus Lore','978-0-06-197805-0','HarperCollins','1st','Science Fiction','available',0),('BK-0036','The Rise of Nine','Pittacus Lore','978-0-06-197807-4','HarperCollins','1st','Science Fiction','available',0),('BK-0037','The Fall of Five','Pittacus Lore','978-0-06-197461-8','HarperCollins','1st','Science Fiction','available',0),('BK-0038','The Revenge of Seven','Pittacus Lore','978-0-06-219472-5','HarperCollins','1st','Science Fiction','available',0),('BK-0039','The Fate of Ten','Pittacus Lore','978-0-06-219474-9','HarperCollins','1st','Science Fiction','available',0),('BK-0040','United as One','Pittacus Lore','978-0-06-219477-0','HarperCollins','1st','Science Fiction','available',0),('BK-0041','Twilight','Stephanie Meyer','978-0-316-16017-9','Little, Brown','1st','Fantasy','available',0),('BK-0042','The Twilight Saga: New Moon','Stephanie Meyer','978-0-316-16020-9','Little, Brown','1st','Fantasy','available',0),('BK-0043','The Twilight Saga: Eclipse','Stephanie Meyer','978-0-316-16022-3','Little, Brown','1st','Fantasy','available',0),('BK-0044','The Twilight Saga: Breaking Dawn','Stephanie Meyer','978-0-316-16024-7','Little, Brown','1st','Fantasy','available',0),('BK-0045','The Da Vinci Code','Dan Brown','978-0-385-50420-8','Doubleday','1st','Thriller','available',0),('BK-0046','The Diary of a Young Girl','Anne Frank','978-0-553-29698-3','Bantam','1st','Non-Fiction','available',0),('BK-0047','Pride and Prejudice','Jane Austen','978-0-141-43951-8','Penguin Classics','1st','Romance','available',0),('BK-0048','Little Women','Louisa May Alcott','978-0-307-95656-3','Penguin Classics','1st','Historical Fiction','available',0),('BK-0049','To Kill a Mockingbird','Harper Lee','978-0-06-112008-4','HarperCollins','1st','Historical Fiction','available',0),('BK-0050','The Catcher in the Rye','J.D. Salinger','978-0-316-76948-0','Little, Brown','1st','Literary Fiction','available',0),('BK-0051','The Hobbit','J.R.R. Tolkien','978-0-345-33968-3','Houghton Mifflin','1st','Fantasy','available',0),('BK-0052','The Fellowship of the Ring','J.R.R. Tolkien','978-0-618-00222-8','Houghton Mifflin','1st','Fantasy','available',0),('BK-0053','The Two Towers','J.R.R. Tolkien','978-0-618-00223-5','Houghton Mifflin','1st','Fantasy','available',0),('BK-0054','The Return of the King','J.R.R. Tolkien','978-0-618-00224-2','Houghton Mifflin','1st','Fantasy','available',0),('BK-0055','Persuasion','Jane Austen','978-0-141-43951-9','Penguin Classics','1st','Romance','available',0),('BK-0056','Animal Farm','George Orwell','978-0-452-28424-1','Plume','1st','Non-Fiction','available',0),('BK-0057','A Tale of Two Cities','Charles Dickens','978-0-141-43952-6','Penguin Classics','1st','Historical Fiction','available',0),('BK-0058','The Great Gatsby','F. Scott Fitzgerald','978-0-7432-7356-5','Scribner','1st','Classic','available',0),('BK-0059','The Picture of Dorian Gray','Oscar Wilde','978-0-486-28218-8','Dover Publications','1st','Classic','available',0),('BK-0060','Moby Dick','Herman Melville','978-0-553-21311-2','Bantam Classics','1st','Adventure','available',0),('BK-0061','Les Misérables','Victor Hugo','978-0-451-52807-8','Signet','1st','Historical Fiction','available',0),('BK-0062','Iliad','Homer','978-0-14-027536-0','Penguin Classics','1st','Historical Fiction','available',0),('BK-0063','Odyssey','Homer','978-0-14-026886-7','Penguin Classics','1st','Adventure','available',0),('BK-0064','Hamlet','William Shakespeare','978-0-7434-7712-3','Simon & Schuster','1st','Tragedy','available',0),('BK-0065','A Midsummer Night\'s Dream','William Shakespeare','978-0-7434-7713-0','Simon & Schuster','1st','Fantasy','available',0),('BK-0066','Romeo and Juliet','William Shakespeare','978-0-7434-7714-7','Simon & Schuster','1st','Romance','available',0),('BK-0067','The Merchant of Venice','William Shakespeare','978-0-7434-7715-4','Simon & Schuster','1st','Drama','available',0),('BK-0068','Julius Caesar','William Shakespeare','978-0-7434-7716-1','Simon & Schuster','1st','Tragedy','available',0),('BK-0069','Macbeth','William Shakespeare','978-0-7434-7717-8','Simon & Schuster','1st','Tragedy','available',0),('BK-0070','Alexander Hamilton','Ron Chernow','978-0-14-303475-9','Penguin Books','1st','Non-Fiction','available',0),('BK-0071','Jane Eyre','Charlotte Brontë','978-0-14-144114-6','Penguin Classics','1st','Romance','available',0),('BK-0072','Don Quixote','Miguel de Cervantes','978-0-06-093434-7','Harper Perennial','1st','Adventure','available',0),('BK-0073','Sense and Sensibility','Jane Austen','978-0-14-143966-2','Penguin Classics','1st','Romance','available',0),('BK-0074','Great Expectations','Charles Dickens','978-0-14-143956-3','Penguin Classics','1st','Drama','available',0),('BK-0075','The Handmaid\'s Tale','Margaret Atwood','978-0-385-49081-8','Anchor Books','1st','Science Fiction','available',0),('BK-0076','Nineteen Eighty-Four','George Orwell','978-0-452-28423-4','Plume','1st','Science Fiction','available',0),('BK-0077','Fantastic Beasts and Where to Find Them','J.K. Rowling','978-1-338-10906-1','Scholastic','1st','Fantasy','available',0),('BK-0078','Fantastic Beasts: The Crimes of Grindelwald','J.K. Rowling','978-1-338-25766-3','Scholastic','1st','Fantasy','available',0),('BK-0079','Fantastic Beasts: The Secrets of Dumbledore','J.K. Rowling','978-1-338-83537-3','Scholastic','1st','Fantasy','available',0);
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

-- Dump completed on 2025-03-18  6:25:52
