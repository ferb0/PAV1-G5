-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: maxikiosko
-- ------------------------------------------------------
-- Server version	8.0.16

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
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cliente` (
  `dni` int(10) unsigned NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `mail` varchar(45) DEFAULT NULL,
  `id_cuenta` int(10) unsigned NOT NULL,
  `domicilio` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`dni`),
  KEY `fk_cliente_cuenta_corriente` (`id_cuenta`),
  CONSTRAINT `fk_cliente_cuenta_corriente` FOREIGN KEY (`id_cuenta`) REFERENCES `cuenta_corriente` (`id_cuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'CONSUMIDOR','FINAL','-','-',6,'maestro Lopez s/n'),(10666555,'Luis','Damiano','(351)123-4567','luis.damiano@net.com',6,'maestro Lopez s/n'),(12345678,'Perez','Juan','(351)123-4567','juan.perez@net.com',5,'Colon 123'),(25896574,'Alguno','Alguien','(351)886-9555','alguno@alguien.com',8,'Calle 45');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `compra` (
  `id_compra` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fecha_hora` datetime DEFAULT NULL,
  `proveedor_cuit` bigint(20) unsigned NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `numero_comprobante` int(11) DEFAULT NULL,
  `total` float DEFAULT NULL,
  PRIMARY KEY (`id_compra`,`proveedor_cuit`),
  KEY `fk_compra_proveedor1_idx` (`proveedor_cuit`),
  KEY `fk_compra_usuario1_idx` (`id_usuario`),
  CONSTRAINT `fk_compra_proveedor1` FOREIGN KEY (`proveedor_cuit`) REFERENCES `proveedor` (`cuit`),
  CONSTRAINT `fk_compra_usuario1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
INSERT INTO `compra` VALUES (6,'2019-05-22 19:22:00',1234567,1,4321,20),(7,'2019-05-22 19:23:00',1234567,1,1222,46),(8,'2019-05-22 19:37:00',1234567,1,123,1),(9,'2019-05-22 20:59:00',1234567,1,3456789,50),(10,'2019-05-22 20:17:00',1234567,1,123,1),(11,'2019-05-22 20:27:00',1234567,1,123123,5),(12,'2019-05-22 20:50:00',1234567,1,123123,600),(13,'2019-05-22 20:29:00',1234567,1,123123,4920),(14,'2019-05-22 20:23:00',1234567,1,123,40);
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuenta_corriente`
--

DROP TABLE IF EXISTS `cuenta_corriente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cuenta_corriente` (
  `id_cuenta` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `balance` float DEFAULT NULL,
  `limite_credito` float DEFAULT NULL,
  PRIMARY KEY (`id_cuenta`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuenta_corriente`
--

LOCK TABLES `cuenta_corriente` WRITE;
/*!40000 ALTER TABLE `cuenta_corriente` DISABLE KEYS */;
INSERT INTO `cuenta_corriente` VALUES (1,0,1000),(2,0,1000),(3,0,1000),(4,0,1000),(5,0,1000),(6,0,100),(7,0,100),(8,0,10000),(9,0,10000);
/*!40000 ALTER TABLE `cuenta_corriente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_compra`
--

DROP TABLE IF EXISTS `detalle_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `detalle_compra` (
  `id_detalle_compra` int(11) NOT NULL AUTO_INCREMENT,
  `id_producto` bigint(20) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `costo` float DEFAULT NULL,
  `porc_iva` float DEFAULT NULL,
  `id_compra` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id_detalle_compra`,`id_producto`,`id_compra`),
  KEY `fk_detalle_compra_producto1_idx` (`id_producto`),
  KEY `fk_id_compra_idx` (`id_compra`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_compra`
--

LOCK TABLES `detalle_compra` WRITE;
/*!40000 ALTER TABLE `detalle_compra` DISABLE KEYS */;
INSERT INTO `detalle_compra` VALUES (6,1,23,2,1,7),(7,1,1,1,1,8),(8,1,1,50,5,9),(9,1,1,1,1,10),(10,1,1,5,1,11),(11,1,50,12,2,12),(12,1,40,123,1,13),(13,1,40,1,1,14);
/*!40000 ALTER TABLE `detalle_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_venta`
--

DROP TABLE IF EXISTS `detalle_venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `detalle_venta` (
  `id_detalle_venta` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` int(10) unsigned DEFAULT NULL,
  `precio_historico` float DEFAULT NULL,
  `id_producto` bigint(20) NOT NULL,
  PRIMARY KEY (`id_detalle_venta`,`id_producto`),
  KEY `fk_detalle_venta_producto1_idx` (`id_producto`),
  CONSTRAINT `fk_detalle_venta_producto1` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`id_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_venta`
--

LOCK TABLES `detalle_venta` WRITE;
/*!40000 ALTER TABLE `detalle_venta` DISABLE KEYS */;
INSERT INTO `detalle_venta` VALUES (1,4,45,1),(2,5,45,1),(3,5,45,1),(4,1,45,1),(4,5,200,123),(5,4,45,1),(5,1,200,123);
/*!40000 ALTER TABLE `detalle_venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `forma_pago`
--

DROP TABLE IF EXISTS `forma_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `forma_pago` (
  `id_forma_pago` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_forma_pago`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `forma_pago`
--

LOCK TABLES `forma_pago` WRITE;
/*!40000 ALTER TABLE `forma_pago` DISABLE KEYS */;
INSERT INTO `forma_pago` VALUES (1,'Tarjeta de Credito'),(2,'Efectivo');
/*!40000 ALTER TABLE `forma_pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_cuenta_corriente`
--

DROP TABLE IF EXISTS `movimiento_cuenta_corriente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `movimiento_cuenta_corriente` (
  `id_movimiento` int(11) NOT NULL,
  `fecha_hora` date DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `monto` float DEFAULT NULL,
  `id_cuenta` int(10) unsigned NOT NULL,
  `id_detalle_venta` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  PRIMARY KEY (`id_movimiento`,`id_cuenta`,`id_detalle_venta`,`id_usuario`),
  KEY `fk_movimiento_cuenta_corriente_cuenta_corriente1_idx` (`id_cuenta`),
  KEY `fk_movimiento_cuenta_corriente_venta1_idx` (`id_detalle_venta`),
  KEY `fk_movimiento_cuenta_corriente_usuario1_idx` (`id_usuario`),
  CONSTRAINT `fk_movimiento_cuenta_corriente_cuenta_corriente1` FOREIGN KEY (`id_cuenta`) REFERENCES `cuenta_corriente` (`id_cuenta`),
  CONSTRAINT `fk_movimiento_cuenta_corriente_usuario1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`),
  CONSTRAINT `fk_movimiento_cuenta_corriente_venta1` FOREIGN KEY (`id_detalle_venta`) REFERENCES `venta` (`id_detalle_venta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_cuenta_corriente`
--

LOCK TABLES `movimiento_cuenta_corriente` WRITE;
/*!40000 ALTER TABLE `movimiento_cuenta_corriente` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimiento_cuenta_corriente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `producto` (
  `id_producto` bigint(20) NOT NULL,
  `tipo_producto` int(10) unsigned NOT NULL,
  `precio` float DEFAULT NULL,
  `stock` int(11) DEFAULT '0',
  `descripcion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_producto`),
  KEY `fk_producto_tipo_producto_idx` (`tipo_producto`),
  CONSTRAINT `fk_producto_tipo_producto` FOREIGN KEY (`tipo_producto`) REFERENCES `tipo_producto` (`id_tipo_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,1,45,40,'Leche'),(123,2,200,0,'Fernet chico');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `proveedor` (
  `cuit` bigint(20) unsigned NOT NULL,
  `razon_social` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`cuit`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1234567,'Arcor','(351)123-4567','arcor@arcor.com');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `rol` (
  `id_rol` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_rol`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol` VALUES (1,'Admin','Rol de Administrador'),(2,'Usuario','Perfil de Usuario');
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_producto`
--

DROP TABLE IF EXISTS `tipo_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tipo_producto` (
  `id_tipo_producto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_tipo_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_producto`
--

LOCK TABLES `tipo_producto` WRITE;
/*!40000 ALTER TABLE `tipo_producto` DISABLE KEYS */;
INSERT INTO `tipo_producto` VALUES (1,'Comestible'),(2,'Bebida');
/*!40000 ALTER TABLE `tipo_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(45) NOT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `password` varchar(256) NOT NULL,
  `rol` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_usuario`),
  KEY `fk_id_rol_idx` (`rol`),
  CONSTRAINT `fk_id_rol` FOREIGN KEY (`rol`) REFERENCES `rol` (`id_rol`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8 COMMENT='Usuarios Ingreso al Sistema';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'admin','admin','admin','u0IbCWAhxd82qmbzotME3w==',1),(22,'fer','Becerra','Fernando','xieVv0/xkrONMTd8NtIdiQ==',1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `venta` (
  `nro_ticket` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fecha_hora` date DEFAULT NULL,
  `total` float DEFAULT NULL,
  `dni` int(10) DEFAULT NULL,
  `id_forma_pago` int(10) unsigned NOT NULL,
  `id_detalle_venta` int(11) NOT NULL,
  PRIMARY KEY (`nro_ticket`,`id_forma_pago`,`id_detalle_venta`),
  KEY `fk_venta_forma_pago1_idx` (`id_forma_pago`),
  KEY `fk_venta_detalle_venta1_idx` (`id_detalle_venta`),
  CONSTRAINT `fk_venta_detalle_venta1` FOREIGN KEY (`id_detalle_venta`) REFERENCES `detalle_venta` (`id_detalle_venta`),
  CONSTRAINT `fk_venta_forma_pago1` FOREIGN KEY (`id_forma_pago`) REFERENCES `forma_pago` (`id_forma_pago`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
INSERT INTO `venta` VALUES (1,'2019-05-22',180,NULL,1,1),(2,'2019-05-22',225,NULL,1,2),(3,'2019-05-22',225,NULL,1,3),(4,'2019-05-22',1045,NULL,1,4),(5,'2019-05-22',380,NULL,2,5);
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-05-23 10:22:01
