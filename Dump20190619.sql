-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: maxikiosko
-- ------------------------------------------------------
-- Server version	5.7.26-log

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
-- Dumping routines for database 'maxikiosko'
--
/*!50003 DROP PROCEDURE IF EXISTS `spRptVentas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spRptVentas`()
BEGIN
SELECT venta.nro_ticket, venta.fecha_hora, venta.dni, cliente.nombre, cliente.apellido, venta.id_detalle_venta, forma_pago.descripcion as forma_pago, detalle_venta.cantidad, producto.descripcion AS producto, detalle_venta.precio_historico
FROM producto INNER JOIN
                         detalle_venta ON producto.id_producto = detalle_venta.id_producto INNER JOIN
                         tipo_producto ON producto.tipo_producto = tipo_producto.id_tipo_producto INNER JOIN
                         venta ON detalle_venta.id_detalle_venta = venta.id_detalle_venta INNER JOIN
                         cliente ON venta.dni = cliente.dni INNER JOIN
                         forma_pago ON venta.id_forma_pago = forma_pago.id_forma_pago
GROUP BY venta.nro_ticket, venta.total, venta.id_detalle_venta, producto.descripcion;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spRptVentasWithPrompt` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spRptVentasWithPrompt`(IN StartDate datetime, IN EndDate datetime)
BEGIN

if StartDate = '' then 
	set StartDate = '1900-01-01';
end if;
if EndDate = '' then 
	set EndDate = now();
end if;

SELECT venta.nro_ticket, venta.fecha_hora, venta.dni, cliente.nombre, cliente.apellido, venta.id_detalle_venta, forma_pago.descripcion as forma_pago, detalle_venta.cantidad, producto.descripcion AS producto, detalle_venta.precio_historico
FROM producto INNER JOIN
                         detalle_venta ON producto.id_producto = detalle_venta.id_producto INNER JOIN
                         tipo_producto ON producto.tipo_producto = tipo_producto.id_tipo_producto INNER JOIN
                         venta ON detalle_venta.id_detalle_venta = venta.id_detalle_venta INNER JOIN
                         cliente ON venta.dni = cliente.dni INNER JOIN
                         forma_pago ON venta.id_forma_pago = forma_pago.id_forma_pago
						 WHERE venta.fecha_hora >= StartDate
						 AND venta.fecha_hora <= EndDate
GROUP BY venta.nro_ticket, venta.total, venta.id_detalle_venta, producto.descripcion;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-19  0:41:23
