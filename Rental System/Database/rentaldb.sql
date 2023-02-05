-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jun 11, 2020 at 08:43 PM
-- Server version: 5.6.12-log
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `rentaldb`
--
CREATE DATABASE IF NOT EXISTS `rentaldb` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `rentaldb`;

-- --------------------------------------------------------

--
-- Stand-in structure for view `qrental`
--
CREATE TABLE IF NOT EXISTS `qrental` (
`id` int(11)
,`transno` varchar(50)
,`cid` int(11)
,`fullname` varchar(250)
,`plateno` varchar(50)
,`dborrowed` date
,`dreturned` date
,`rental` decimal(10,0)
,`rentalpay` decimal(10,0)
,`remarks` text
,`status` varchar(50)
);
-- --------------------------------------------------------

--
-- Table structure for table `tblbrand`
--

CREATE TABLE IF NOT EXISTS `tblbrand` (
  `brand` varchar(50) NOT NULL,
  PRIMARY KEY (`brand`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbrand`
--

INSERT INTO `tblbrand` (`brand`) VALUES
('HONDA'),
('KAWASAKI'),
('YAMAHA');

-- --------------------------------------------------------

--
-- Table structure for table `tblcustomer`
--

CREATE TABLE IF NOT EXISTS `tblcustomer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fullname` varchar(250) NOT NULL,
  `address` text NOT NULL,
  `bdate` date NOT NULL,
  `contact` varchar(100) NOT NULL,
  `idtype` varchar(50) NOT NULL,
  `idno` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `tblcustomer`
--

INSERT INTO `tblcustomer` (`id`, `fullname`, `address`, `bdate`, `contact`, `idtype`, `idno`) VALUES
(1, 'RESARE, JOEMEL E', 'Surigao City', '1980-06-24', '09077640336', 'School', '113-2014-0738'),
(2, 'SENORIO, VJ ', 'Surigao City', '1997-08-21', '09091234567', 'SSS', '326723647623423');

-- --------------------------------------------------------

--
-- Table structure for table `tblmotor`
--

CREATE TABLE IF NOT EXISTS `tblmotor` (
  `plate` varchar(50) NOT NULL,
  `brand` varchar(50) NOT NULL,
  `model` varchar(50) NOT NULL,
  `color` varchar(50) NOT NULL,
  `rental` double NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Available',
  PRIMARY KEY (`plate`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblmotor`
--

INSERT INTO `tblmotor` (`plate`, `brand`, `model`, `color`, `rental`, `status`) VALUES
('SC1234', 'HONDA', '2015', 'BLACK', 150, 'Available'),
('SC4536', 'KAWASAKI', '2010', 'RED', 120, 'Available'),
('SC6567', 'KAWASAKI', '2020', 'BLACK', 200, 'Available');

-- --------------------------------------------------------

--
-- Table structure for table `tblpayment`
--

CREATE TABLE IF NOT EXISTS `tblpayment` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `transno` varchar(50) NOT NULL,
  `name` text NOT NULL,
  `cash` double NOT NULL,
  `sdate` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Dumping data for table `tblpayment`
--

INSERT INTO `tblpayment` (`id`, `transno`, `name`, `cash`, `sdate`) VALUES
(8, '27715799', 'RESARE, JOEMEL E', 300, '2020-06-11');

-- --------------------------------------------------------

--
-- Table structure for table `tblrent`
--

CREATE TABLE IF NOT EXISTS `tblrent` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `transno` varchar(50) NOT NULL,
  `cid` int(11) NOT NULL,
  `plateno` varchar(50) NOT NULL,
  `dborrowed` date NOT NULL,
  `dreturned` date NOT NULL,
  `rental` decimal(10,0) NOT NULL,
  `noofdays` int(11) NOT NULL,
  `rentalpay` decimal(10,0) NOT NULL,
  `remarks` text NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Borrowed',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=33 ;

--
-- Dumping data for table `tblrent`
--

INSERT INTO `tblrent` (`id`, `transno`, `cid`, `plateno`, `dborrowed`, `dreturned`, `rental`, `noofdays`, `rentalpay`, `remarks`, `status`) VALUES
(4, '38133492', 1, 'SC1234', '2016-10-11', '2016-10-11', '150', 1, '150', '', 'Returned'),
(6, '73583965', 2, 'SC4536', '2016-10-12', '2016-10-12', '120', 1, '120', '', 'Returned'),
(7, '19932081', 2, 'SC1234', '2016-10-11', '2016-10-11', '150', 1, '150', '', 'Returned'),
(25, '75996037', 1, 'SC1234', '2020-06-11', '2020-06-11', '150', 1, '150', '', 'Returned'),
(26, '75996037', 1, 'SC4536', '2020-06-11', '2020-06-11', '120', 1, '120', '', 'Returned'),
(27, '75996037', 1, 'SC6567', '2020-06-11', '2020-06-11', '200', 1, '200', '', 'Returned'),
(31, '27715799', 1, 'SC1234', '2020-06-11', '2020-06-11', '150', 1, '150', '', 'Returned'),
(32, '27715799', 1, 'SC4536', '2020-06-11', '2020-06-11', '120', 1, '120', '', 'Returned');

-- --------------------------------------------------------

--
-- Structure for view `qrental`
--
DROP TABLE IF EXISTS `qrental`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `qrental` AS select `r`.`id` AS `id`,`r`.`transno` AS `transno`,`r`.`cid` AS `cid`,`b`.`fullname` AS `fullname`,`r`.`plateno` AS `plateno`,`r`.`dborrowed` AS `dborrowed`,`r`.`dreturned` AS `dreturned`,`r`.`rental` AS `rental`,`r`.`rentalpay` AS `rentalpay`,`r`.`remarks` AS `remarks`,`r`.`status` AS `status` from (`tblrent` `r` join `tblcustomer` `b` on((`b`.`id` = `r`.`cid`)));

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
