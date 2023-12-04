/*
SQLyog Community v13.2.1 (64 bit)
MySQL - 10.4.28-MariaDB : Database - barangay_task_management_system
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`barangay_task_management_system` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `barangay_task_management_system`;

/*Table structure for table `projects` */

DROP TABLE IF EXISTS `projects`;

CREATE TABLE `projects` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `start_date` date NOT NULL,
  `due_date` date NOT NULL,
  `status` enum('Started','Ongoing','Finished','Missed') NOT NULL,
  `total_tasks` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `projects` */

insert  into `projects`(`id`,`name`,`description`,`start_date`,`due_date`,`status`,`total_tasks`) values 
(1,'Sample Project 1','Sample Project Description','2023-12-04','2023-12-30','Started',3),
(2,'Sample Project 2','Sample Project Description\nSample Project Description','2023-12-04','2023-12-30','Ongoing',3),
(3,'Sample Project 3','Sample Project Description','2023-12-04','2024-01-01','Finished',3),
(4,'Sample Project 4','Sample Project Description\nSample Project Description','2023-12-04','2023-12-04','Missed',3);

/*Table structure for table `tasks` */

DROP TABLE IF EXISTS `tasks`;

CREATE TABLE `tasks` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `project_id` int(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  `due_date` date NOT NULL,
  `status` enum('Pending','Finished','Missed') NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_ProjectID` (`project_id`),
  CONSTRAINT `FK_ProjectID` FOREIGN KEY (`project_id`) REFERENCES `projects` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `tasks` */

insert  into `tasks`(`id`,`project_id`,`name`,`description`,`due_date`,`status`) values 
(1,1,'Sample Task 1','Sample Task Description','2023-12-25','Pending'),
(2,1,'Sample Task 2','Sample Task Description','2023-12-25','Pending'),
(3,1,'Sample Task 3','Sample Task Description','2023-12-25','Pending'),
(4,2,'Sample Task 1','Sample Task Description','2023-12-04','Finished'),
(5,2,'Sample Task 2','Sample Task Description','2023-12-04','Missed'),
(6,3,'Sample Task 1','Sample Task Description','2024-01-01','Finished'),
(7,3,'Sample Task 2','Sample Task Description','2024-01-01','Finished'),
(8,4,'Sample Task 1','Sample Task Description','2023-12-04','Pending'),
(10,2,'Sample Task 3','Sample Task Description','2023-12-30','Finished'),
(11,3,'Sample Task 3','Sample Task Description','2024-01-01','Finished'),
(12,4,'Sample Task 2','Sample Task Description','2023-12-04','Finished'),
(13,4,'Sample Task 3','Sample Task Description','2023-12-04','Pending');

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(255) NOT NULL,
  `middle_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `date` date NOT NULL,
  `is_superuser` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `users` */

insert  into `users`(`id`,`first_name`,`middle_name`,`last_name`,`email`,`password`,`date`,`is_superuser`) values 
(1,'Khatrina','Belo','Angeles','khat@gmail.com','khat','2023-11-21',1),
(2,'Seanrei','Ethan','Valdeabella','sean@gmail.com','sean','2023-12-04',0),
(3,'admin','admin','admin','admin','admin','2023-12-04',1),
(4,'user','user','user','user','user','2023-12-04',0);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
