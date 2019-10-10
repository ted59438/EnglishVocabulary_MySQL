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

-- 正在傾印表格  ithome2019_englishvocabulary.category 的資料：~1 rows (約數)
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` (`CategoryID`, `CategoryName`) VALUES
	('7cf2fee6-7f62-4483-befb-a44b9bd3c0e2', 'Transportation 交通');
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

-- 正在傾印表格  ithome2019_englishvocabulary.exam_detail 的資料：~2 rows (約數)
/*!40000 ALTER TABLE `exam_detail` DISABLE KEYS */;
INSERT INTO `exam_detail` (`Exam_DetailID`, `ExamID`, `OrderNumber`, `VocabularyID`, `IsCorrect`) VALUES
	('6d58772e-1f93-4606-935e-8fd8b4f7d915', '03ede7e5-cb6f-484b-9e4f-8048f20bc989', 2, '89abe669-7468-4206-b561-1d9d7f029dd3', 1),
	('9d2e94dc-2e85-400a-9574-65d10837b365', '03ede7e5-cb6f-484b-9e4f-8048f20bc989', 1, 'd2832d3b-2c85-4668-b92e-0403da983a28', 1);
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
  KEY `IDX_exam_master_EndDateTime` (`EndDateTime`),
  KEY `IDX_exam_master_StartDateTime` (`StartDateTime`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在傾印表格  ithome2019_englishvocabulary.exam_master 的資料：~1 rows (約數)
/*!40000 ALTER TABLE `exam_master` DISABLE KEYS */;
INSERT INTO `exam_master` (`ExamID`, `StartDateTime`, `EndDateTime`, `CategoryID`, `StudentID`, `CorrectNumber`, `WrongNumber`, `Rate`) VALUES
	('03ede7e5-cb6f-484b-9e4f-8048f20bc989', '2019-10-10 16:24:12', '2019-10-10 16:24:18', '7cf2fee6-7f62-4483-befb-a44b9bd3c0e2', 'b84a76a3-bc8e-46b3-b89c-e8c0f65b38f5', 2, 0, 100.00);
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AVG_ROW_LENGTH=16384;

-- 正在傾印表格  ithome2019_englishvocabulary.student 的資料：~3 rows (約數)
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` (`StudentID`, `Username`, `Password`, `RealName`, `Birthdate`) VALUES
	('37ac264e-6576-413e-8a35-d5a509dc1d87', 'test3', '*A4B6157319038724E3560894F7F932C8886EBFCF', '泰中', '2019-10-06 00:00:00'),
	('8facce19-27d7-4660-a62c-b2fcd718a014', 'test2', '1234', '泰大', '2019-10-06 18:56:06'),
	('b84a76a3-bc8e-46b3-b89c-e8c0f65b38f5', 'test1', '*A4B6157319038724E3560894F7F932C8886EBFCF', '泰小', '2019-10-06 18:56:06');
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

-- 正在傾印表格  ithome2019_englishvocabulary.vocabulary 的資料：~2 rows (約數)
/*!40000 ALTER TABLE `vocabulary` DISABLE KEYS */;
INSERT INTO `vocabulary` (`VocabularyID`, `CategoryID`, `English`, `Chinese`, `PartOfSpeech`) VALUES
	('89abe669-7468-4206-b561-1d9d7f029dd3', '7cf2fee6-7f62-4483-befb-a44b9bd3c0e2', 'train', '火車', 'n'),
	('d2832d3b-2c85-4668-b92e-0403da983a28', '7cf2fee6-7f62-4483-befb-a44b9bd3c0e2', 'bicycle', '腳踏車', 'n');
/*!40000 ALTER TABLE `vocabulary` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
