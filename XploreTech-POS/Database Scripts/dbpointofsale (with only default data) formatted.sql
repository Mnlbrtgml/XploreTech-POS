CREATE DATABASE  IF NOT EXISTS `dbpointofsale`;
USE `dbpointofsale`;

DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `User_ID` int(3) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Full_Name` varchar(50) CHARACTER SET latin1 COLLATE latin1_general_cs NOT NULL,
  `User_Type` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Username` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Password` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Updated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `is_archive` tinyint NOT NULL DEFAULT 0,
  PRIMARY KEY (`User_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;

DROP TABLE IF EXISTS `activitylog`;
CREATE TABLE `activitylog` (
  `Activity_Log_ID` int unsigned NOT NULL AUTO_INCREMENT,
  `User_ID` int(3) unsigned zerofill NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Activity` varchar(45) NOT NULL,
  `Created_At` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Activity_Log_ID`),
  FOREIGN KEY (`User_ID`) REFERENCES `user`(`User_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `additional_products`;
CREATE TABLE `additional_products` (
  `Additional_Products_ID` int(2) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Price` int unsigned NOT NULL,
  `Status` varchar(45) NOT NULL,
  `Updated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Additional_Products_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `cup_size`;
CREATE TABLE `cup_size` (
  `Cup_Size_ID` int(2) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Price` int unsigned NOT NULL,
  `Stocks` int unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`Cup_Size_ID`),
  UNIQUE KEY `Name` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `customertype`;
CREATE TABLE `customertype` (
  `Customer_Type_ID` int(2) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Discount` double NOT NULL,
  PRIMARY KEY (`Customer_Type_ID`),
  UNIQUE KEY `Name` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer` (
  `Customer_ID` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Customer_Type_ID` int(2) unsigned zerofill NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Contact_Number` varchar(11) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Number_of_Purchase` int NOT NULL,
  `Updated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Customer_ID`),
  FOREIGN KEY (`Customer_Type_ID`) REFERENCES `customertype`(`Customer_Type_ID`),
  UNIQUE KEY `Name` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `unregistered_customer`;
CREATE TABLE `unregistered_customer` (
  `Unregistered_Customer_ID` int(4) zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  `Contact_Number` varchar(11) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Date_Created` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Unregistered_Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `milktea`;
CREATE TABLE `milktea` (
  `Milktea_ID` int(5) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Price` int unsigned NOT NULL,
  `Status` varchar(45) NOT NULL,
  `Updated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Milktea_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `others`;
CREATE TABLE `others` (
  `Others_ID` int(2) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Stock` int unsigned NOT NULL DEFAULT '0',
  `is_displayed` tinyint(1) NOT NULL DEFAULT '0',
  `Updated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Others_ID`),
  UNIQUE KEY `Name` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `payment_type`;
CREATE TABLE `payment_type` (
  `Payment_Type_ID` int(2) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Payment_Type_ID`),
  UNIQUE KEY `Name` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `promo`;
CREATE TABLE `promo` (
  `Promo_ID` int(2) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Description` longtext NOT NULL,
  `Discount` double NOT NULL DEFAULT '0',
  `Enable` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Promo_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `service_type`;
CREATE TABLE `service_type` (
  `Service_Type_ID` int(2) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Fee` decimal NOT NULL DEFAULT '0',
  PRIMARY KEY (`Service_Type_ID`),
  UNIQUE KEY `Name` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `sugar_level`;
CREATE TABLE `sugar_level` (
  `Sugar_Level_ID` int(2) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Sugar_Level_ID`),
  UNIQUE KEY `Name` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `add_ons`;
CREATE TABLE `add_ons` (
  `Add_Ons_ID` int(2) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Price` int unsigned NOT NULL,
  `Status` varchar(45) NOT NULL,
  `Updated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Add_Ons_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

DROP TABLE IF EXISTS `receipt`;CREATE TABLE `receipt` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Receipt_ID` int(6) unsigned zerofill NOT NULL,
  `Payment_Type_ID` int(2) unsigned zerofill NOT NULL,
  `Service_Type_ID` int(2) unsigned zerofill NOT NULL,
  `User_ID` int(3) unsigned zerofill NOT NULL,
  `Customer_ID` int(4) unsigned zerofill default null,
  `Unregistered_Customer_ID` int(4) zerofill default null, -- if customer is not registered
  `Milktea_ID` int(5) unsigned zerofill,
  `Cup_Size_ID` int(2) unsigned zerofill,
  `Add_Ons` varchar(50) Default null,
  `Additional_Products_ID` int(2) unsigned zerofill,
  `Quantity` int NOT NULL,
  `Price` DECIMAL NOT NULL,
  `Payment` DECIMAL NOT NULL DEFAULT '0',
  `Discount` DECIMAL NOT NULL DEFAULT '0',
  `Date_Processed` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`),
  FOREIGN KEY (`Payment_Type_ID`) REFERENCES `payment_type`(`Payment_Type_ID`),
  FOREIGN KEY (`Service_Type_ID`) REFERENCES `service_type`(`Service_Type_ID`),
  FOREIGN KEY (`User_ID`) REFERENCES `user`(`User_ID`),
  FOREIGN KEY (`Customer_ID`) REFERENCES `customer`(`Customer_ID`),
  FOREIGN KEY (`Unregistered_Customer_ID`) REFERENCES `unregistered_customer`(`Unregistered_Customer_ID`),
  FOREIGN KEY (`Milktea_ID`) REFERENCES `milktea`(`Milktea_ID`),
  FOREIGN KEY (`Cup_Size_ID`) REFERENCES `cup_size`(`Cup_Size_ID`),
  FOREIGN KEY (`Additional_Products_ID`) REFERENCES `additional_products`(`Additional_Products_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

DROP TABLE IF EXISTS `transaction`;
CREATE TABLE `transaction` (
  `Transaction_ID` int(6) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Receipt_ID` int NOT NULL,
  `Payment_Type_ID` int(2) unsigned zerofill NOT NULL,
  `Service_Type_ID` int(2) unsigned zerofill NOT NULL,
  `User_ID` int(3) unsigned zerofill NOT NULL,
  `Customer_ID` int(4) unsigned zerofill ,
  `Customer_Type_ID` int(2) unsigned zerofill ,
  `Milktea_ID` int(5) unsigned zerofill,
  `Cup_Size_ID` int(2) unsigned zerofill,
  `Additional_Products_ID` int(2) unsigned zerofill,
  `Sugar_Level_ID` int(2) unsigned zerofill,
  `Promo_ID` int(2) unsigned zerofill,
  `Other_Items` json DEFAULT NULL,
  `Add_Ons` varchar(50),
  `Date_Processed` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Transaction_ID`),
  FOREIGN KEY (`Receipt_ID`) REFERENCES `receipt`(`ID`),
  FOREIGN KEY (`Payment_Type_ID`) REFERENCES `payment_type`(`Payment_Type_ID`),
  FOREIGN KEY (`Service_Type_ID`) REFERENCES `service_type`(`Service_Type_ID`),
  FOREIGN KEY (`User_ID`) REFERENCES `user`(`User_ID`),
  FOREIGN KEY (`Customer_ID`) REFERENCES `customer`(`Customer_ID`),
  FOREIGN KEY (`Customer_Type_ID`) REFERENCES `customertype`(`Customer_Type_ID`),
  FOREIGN KEY (`Milktea_ID`) REFERENCES `milktea`(`Milktea_ID`),
  FOREIGN KEY (`Cup_Size_ID`) REFERENCES `cup_size`(`Cup_Size_ID`),
  FOREIGN KEY (`Additional_Products_ID`) REFERENCES `additional_products`(`Additional_Products_ID`),
  FOREIGN KEY (`Sugar_Level_ID`) REFERENCES `sugar_level`(`Sugar_Level_ID`),
  FOREIGN KEY (`Promo_ID`) REFERENCES `promo`(`Promo_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=100000 DEFAULT CHARSET=utf8;

-- Insert Functions Below

INSERT INTO `customertype` VALUES (01,'Regular',0.00);

INSERT INTO `payment_type` VALUES (01,'Cash'),(02,'G-Cash'),(03,'Pay-Maya');

INSERT INTO `service_type` VALUES 
(01,'Dine-in', default),
(02,'Take-out', default);

INSERT INTO `sugar_level` VALUES (01,'0%'),
(02,'25%'),
(03,'50%'),
(04,'75%'),
(05,'100%');

INSERT INTO `unregistered_customer` VALUES (1, '', '', '', default);