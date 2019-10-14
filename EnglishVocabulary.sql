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

-- 正在傾印表格  ithome2019_englishvocabulary.category 的資料：~2 rows (約數)
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` (`CategoryID`, `CategoryName`) VALUES
	('715acfba-b218-471a-afa6-a13568b331a1', 'Food 食物'),
	('7cf2fee6-7f62-4483-befb-a44b9bd3c0e2', 'Transportation 交通');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;

-- 傾印  表格 ithome2019_englishvocabulary.exam_detail 結構
CREATE TABLE IF NOT EXISTS `exam_detail` (
  `Exam_DetailID` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `ExamID` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `OrderNumber` int(11) DEFAULT NULL,
  `VocabularyID` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IsCorrect` tinyint(1) DEFAULT NULL,
  `UserAnswer` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`Exam_DetailID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在傾印表格  ithome2019_englishvocabulary.exam_detail 的資料：~8 rows (約數)
/*!40000 ALTER TABLE `exam_detail` DISABLE KEYS */;
INSERT INTO `exam_detail` (`Exam_DetailID`, `ExamID`, `OrderNumber`, `VocabularyID`, `IsCorrect`, `UserAnswer`) VALUES
	('05040ee5-e02b-48a1-97f7-c52be7d9dc49', '74d18261-a4d2-49ea-b23c-e04e54cfcb43', 2, '9043ff22-0bf2-4e1b-8921-dfe515402697', 1, 'chicken'),
	('4612d2cd-4b89-486b-8bc1-8487826adefb', '74d18261-a4d2-49ea-b23c-e04e54cfcb43', 4, 'f39d73bc-0601-412a-b91f-947baabdb603', 1, 'fish'),
	('4714fd64-ccb1-4daa-adef-1651e6bc41e5', '41aa3cb8-15ee-44d5-b17c-36a270f1b123', 2, '8a33a002-0faa-4a9f-ae96-d3e09bacb452', 1, 'motorcycle'),
	('773cbf21-afbb-40ee-99e8-ae241f074155', '41aa3cb8-15ee-44d5-b17c-36a270f1b123', 3, '89abe669-7468-4206-b561-1d9d7f029dd3', 1, 'train'),
	('86f93eb1-f936-4618-b633-593f794e0e2f', '74d18261-a4d2-49ea-b23c-e04e54cfcb43', 5, 'b3038177-2365-4897-adc9-1f3a54547b84', 1, 'noodle'),
	('a0c9f738-5bed-4b8e-bd12-516f60b32f0d', '41aa3cb8-15ee-44d5-b17c-36a270f1b123', 1, 'd2832d3b-2c85-4668-b92e-0403da983a28', 1, 'bicycle'),
	('ae16a070-2f4c-48c7-858f-c0237a5e4349', '74d18261-a4d2-49ea-b23c-e04e54cfcb43', 1, 'e684d712-94c3-4a2b-a9fa-5dd91b02e3ed', 1, 'pork'),
	('e30568f5-900d-4a4b-a0c8-b5bafa91b76a', '74d18261-a4d2-49ea-b23c-e04e54cfcb43', 3, '0e83b5bb-01f8-4e9b-9695-e6164b288a72', 1, 'meat');
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
  `Rate` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`ExamID`),
  KEY `IDX_exam_master_EndDateTime` (`EndDateTime`),
  KEY `IDX_exam_master_StartDateTime` (`StartDateTime`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在傾印表格  ithome2019_englishvocabulary.exam_master 的資料：~2 rows (約數)
/*!40000 ALTER TABLE `exam_master` DISABLE KEYS */;
INSERT INTO `exam_master` (`ExamID`, `StartDateTime`, `EndDateTime`, `CategoryID`, `StudentID`, `CorrectNumber`, `WrongNumber`, `Rate`) VALUES
	('41aa3cb8-15ee-44d5-b17c-36a270f1b123', '2019-10-14 01:42:02', '2019-10-14 01:42:10', '7cf2fee6-7f62-4483-befb-a44b9bd3c0e2', '43d49548-6584-4f2b-b70b-2cfd7d188222', 3, 0, 100.00),
	('74d18261-a4d2-49ea-b23c-e04e54cfcb43', '2019-10-13 19:24:26', '2019-10-13 19:24:39', '715acfba-b218-471a-afa6-a13568b331a1', 'c8c18240-82a8-4e6f-b9c6-733c8f6290d7', 5, 0, 100.00);
/*!40000 ALTER TABLE `exam_master` ENABLE KEYS */;

-- 傾印  表格 ithome2019_englishvocabulary.student 結構
CREATE TABLE IF NOT EXISTS `student` (
  `StudentID` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Username` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Password` varchar(300) COLLATE utf8_unicode_ci DEFAULT NULL,
  `RealName` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Birthdate` datetime DEFAULT NULL,
  PRIMARY KEY (`StudentID`),
  UNIQUE KEY `UK_student_Username` (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AVG_ROW_LENGTH=16384;

-- 正在傾印表格  ithome2019_englishvocabulary.student 的資料：~4 rows (約數)
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` (`StudentID`, `Username`, `Password`, `RealName`, `Birthdate`) VALUES
	('32a0cb67-22a0-4ad9-9f42-3f2f7f016bef', 'test4', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', '泰小', '2019-10-01 00:00:00'),
	('43d49548-6584-4f2b-b70b-2cfd7d188222', 'test2', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', '泰大', '2019-10-06 00:00:00'),
	('c8c18240-82a8-4e6f-b9c6-733c8f6290d7', 'test1', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', '泰度', '2019-10-01 00:00:00'),
	('e7b3b71d-2046-4d9c-9f72-c90462bef770', 'test3', 'e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855', '泰中', '2019-10-06 00:00:00');
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

-- 正在傾印表格  ithome2019_englishvocabulary.vocabulary 的資料：~10 rows (約數)
/*!40000 ALTER TABLE `vocabulary` DISABLE KEYS */;
INSERT INTO `vocabulary` (`VocabularyID`, `CategoryID`, `English`, `Chinese`, `PartOfSpeech`) VALUES
	('0e83b5bb-01f8-4e9b-9695-e6164b288a72', '715acfba-b218-471a-afa6-a13568b331a1', 'meat', '肉類', 'n'),
	('290b7825-ecbe-4694-80d4-7ab18bc47516', '715acfba-b218-471a-afa6-a13568b331a1', 'beaf', '牛肉', 'n'),
	('3cbccb74-17c7-4c8e-95d6-292f46f2e6cb', '715acfba-b218-471a-afa6-a13568b331a1', 'rice', '米飯', 'n'),
	('89abe669-7468-4206-b561-1d9d7f029dd3', '7cf2fee6-7f62-4483-befb-a44b9bd3c0e2', 'train', '火車', 'n'),
	('8a33a002-0faa-4a9f-ae96-d3e09bacb452', '7cf2fee6-7f62-4483-befb-a44b9bd3c0e2', 'motorcycle', '摩托車', 'n'),
	('9043ff22-0bf2-4e1b-8921-dfe515402697', '715acfba-b218-471a-afa6-a13568b331a1', 'chicken', '炸雞', 'n'),
	('b3038177-2365-4897-adc9-1f3a54547b84', '715acfba-b218-471a-afa6-a13568b331a1', 'noodle', '麵食', 'n'),
	('d2832d3b-2c85-4668-b92e-0403da983a28', '7cf2fee6-7f62-4483-befb-a44b9bd3c0e2', 'bicycle', '腳踏車', 'n'),
	('e684d712-94c3-4a2b-a9fa-5dd91b02e3ed', '715acfba-b218-471a-afa6-a13568b331a1', 'pork', '豬肉', 'n'),
	('f39d73bc-0601-412a-b91f-947baabdb603', '715acfba-b218-471a-afa6-a13568b331a1', 'fish', '魚類', 'n');
/*!40000 ALTER TABLE `vocabulary` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
