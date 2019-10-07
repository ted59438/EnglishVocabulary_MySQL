-- --------------------------------------------------------
-- 主機:                           127.0.0.1
-- 伺服器版本:                        10.2.22-MariaDB - mariadb.org binary distribution
-- 伺服器操作系統:                      Win64
-- HeidiSQL 版本:                  10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- 傾印 ithome2019_englishvocabulary 的資料庫結構
CREATE DATABASE IF NOT EXISTS `ithome2019_englishvocabulary` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
USE `ithome2019_englishvocabulary`;

-- 傾印  表格 ithome2019_englishvocabulary.category 結構
CREATE TABLE IF NOT EXISTS `category` (
  `CategoryID` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `CategoryName` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`CategoryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在傾印表格  ithome2019_englishvocabulary.category 的資料：~0 rows (約數)
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
/*!40000 ALTER TABLE `category` ENABLE KEYS */;

-- 傾印  表格 ithome2019_englishvocabulary.exam_detail 結構
CREATE TABLE IF NOT EXISTS `exam_detail` (
  `Exam_DetailID` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `ExamID` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `OrderNumber` int(11) DEFAULT NULL,
  `VocabularyID` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IsCorrect` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Exam_DetailID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在傾印表格  ithome2019_englishvocabulary.exam_detail 的資料：~0 rows (約數)
/*!40000 ALTER TABLE `exam_detail` DISABLE KEYS */;
/*!40000 ALTER TABLE `exam_detail` ENABLE KEYS */;

-- 傾印  表格 ithome2019_englishvocabulary.exam_master 結構
CREATE TABLE IF NOT EXISTS `exam_master` (
  `ExamID` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `StartDateTime` datetime DEFAULT NULL,
  `EndDateTime` datetime DEFAULT NULL,
  `CategoryID` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `StudentID` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CorrectNumber` int(11) DEFAULT NULL,
  `WrongNumber` int(11) DEFAULT NULL,
  PRIMARY KEY (`ExamID`),
  KEY `IDX_exam_master_StartDateTime` (`StartDateTime`),
  KEY `IDX_exam_master_EndDateTime` (`EndDateTime`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在傾印表格  ithome2019_englishvocabulary.exam_master 的資料：~0 rows (約數)
/*!40000 ALTER TABLE `exam_master` DISABLE KEYS */;
/*!40000 ALTER TABLE `exam_master` ENABLE KEYS */;

-- 傾印  表格 ithome2019_englishvocabulary.student 結構
CREATE TABLE IF NOT EXISTS `student` (
  `StudentID` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Username` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Password` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `RealName` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Birthdate` datetime DEFAULT NULL,
  PRIMARY KEY (`StudentID`),
  UNIQUE KEY `UK_student_Username` (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在傾印表格  ithome2019_englishvocabulary.student 的資料：~1 rows (約數)
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` (`StudentID`, `Username`, `Password`, `RealName`, `Birthdate`) VALUES
	('8facce19-27d7-4660-a62c-b2fcd718a014', 'test2', '1234', '泰大', '2019-10-06 18:56:06');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;

-- 傾印  表格 ithome2019_englishvocabulary.vocabulary 結構
CREATE TABLE IF NOT EXISTS `vocabulary` (
  `VocabularyID` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `CategoryID` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `English` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Chinese` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `PartOfSpeech` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`VocabularyID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在傾印表格  ithome2019_englishvocabulary.vocabulary 的資料：~0 rows (約數)
/*!40000 ALTER TABLE `vocabulary` DISABLE KEYS */;
/*!40000 ALTER TABLE `vocabulary` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
