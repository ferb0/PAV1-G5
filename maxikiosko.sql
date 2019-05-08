-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema maxikiosko
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema maxikiosko
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `maxikiosko` DEFAULT CHARACTER SET utf8 ;
USE `maxikiosko` ;

-- -----------------------------------------------------
-- Table `maxikiosko`.`cuenta_corriente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`cuenta_corriente`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`cuenta_corriente` (
  `id_cuenta` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `balance` FLOAT NULL,
  `limite_credito` FLOAT NULL,
  PRIMARY KEY (`id_cuenta`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `maxikiosko`.`cliente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`cliente`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`cliente` (
  `dni` INT UNSIGNED NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `apellido` VARCHAR(45) NULL,
  `telefono` VARCHAR(45) NULL,
  `mail` VARCHAR(45) NULL,
  `id_cuenta` INT UNSIGNED NOT NULL,
  `domicilio` VARCHAR(45) NULL,
  PRIMARY KEY (`dni`, `id_cuenta`),
  INDEX `fk_cliente_cuenta_corriente_idx` (`id_cuenta` ASC) VISIBLE,
  CONSTRAINT `fk_cliente_cuenta_corriente`
    FOREIGN KEY (`id_cuenta`)
    REFERENCES `maxikiosko`.`cuenta_corriente` (`id_cuenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `maxikiosko`.`forma_pago`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`forma_pago`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`forma_pago` (
  `id_forma_pago` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(200) NULL,
  PRIMARY KEY (`id_forma_pago`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `maxikiosko`.`tipo_producto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`tipo_producto`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`tipo_producto` (
  `id_tipo_producto` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(200) NULL,
  PRIMARY KEY (`id_tipo_producto`))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `maxikiosko`.`producto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`producto`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`producto` (
  `id_producto` BIGINT NOT NULL,
  `precio` FLOAT NULL,
  `stock` INT NULL DEFAULT 0,
  `descripcion` VARCHAR(200) NULL,
  PRIMARY KEY (`id_producto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `maxikiosko`.`detalle_venta`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`detalle_venta`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`detalle_venta` (
  `id_detalle_venta` INT NOT NULL,
  `cantidad` INT UNSIGNED NULL,
  `precio_historico` FLOAT NULL,
  `id_producto` BIGINT NOT NULL,
  PRIMARY KEY (`id_detalle_venta`, `id_producto`),
  INDEX `fk_detalle_venta_producto1_idx` (`id_producto` ASC) VISIBLE,
  CONSTRAINT `fk_detalle_venta_producto1`
    FOREIGN KEY (`id_producto`)
    REFERENCES `maxikiosko`.`producto` (`id_producto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `maxikiosko`.`venta`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`venta`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`venta` (
  `nro_ticket` INT UNSIGNED NOT NULL,
  `fecha_hora` DATE NULL,
  `total` FLOAT NULL,
  `id_forma_pago` INT UNSIGNED NOT NULL,
  `id_detalle_venta` INT NOT NULL,
  PRIMARY KEY (`nro_ticket`, `id_forma_pago`, `id_detalle_venta`),
  INDEX `fk_venta_forma_pago1_idx` (`id_forma_pago` ASC) VISIBLE,
  INDEX `fk_venta_detalle_venta1_idx` (`id_detalle_venta` ASC) VISIBLE,
  CONSTRAINT `fk_venta_forma_pago1`
    FOREIGN KEY (`id_forma_pago`)
    REFERENCES `maxikiosko`.`forma_pago` (`id_forma_pago`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_venta_detalle_venta1`
    FOREIGN KEY (`id_detalle_venta`)
    REFERENCES `maxikiosko`.`detalle_venta` (`id_detalle_venta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `maxikiosko`.`proveedor`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`proveedor`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`proveedor` (
  `cuit` BIGINT UNSIGNED NOT NULL,
  `razon_social` VARCHAR(45) NULL,
  `telefono` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  PRIMARY KEY (`cuit`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `maxikiosko`.`rol`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`rol`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`rol` (
  `id_rol` INT NOT NULL,
  `descripcion` VARCHAR(200) NULL,
  PRIMARY KEY (`id_rol`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `maxikiosko`.`usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`usuario`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`usuario` (
  `id_usuario` INT NOT NULL,
  `nombre_usuario` VARCHAR(45) NULL,
  `nombre` VARCHAR(45) NULL,
  `apellido` VARCHAR(45) NULL,
  `id_rol` INT NOT NULL,
  PRIMARY KEY (`id_usuario`, `id_rol`),
  INDEX `fk_usuario_rol1_idx` (`id_rol` ASC) VISIBLE,
  CONSTRAINT `fk_usuario_rol1`
    FOREIGN KEY (`id_rol`)
    REFERENCES `maxikiosko`.`rol` (`id_rol`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `maxikiosko`.`detalle_compra`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`detalle_compra`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`detalle_compra` (
  `id_detalle_compra` INT NOT NULL,
  `detalle_compracol` VARCHAR(45) NULL,
  `id_producto` BIGINT NOT NULL,
  `cuit` BIGINT UNSIGNED NOT NULL,
  `cantidad` INT NULL,
  `costo` INT NULL,
  `porc_iva` FLOAT NULL,
  PRIMARY KEY (`id_detalle_compra`, `id_producto`),
  INDEX `fk_detalle_compra_producto1_idx` (`id_producto` ASC) VISIBLE,
  INDEX `fk_detalle_compra_proveedor1_idx` (`cuit` ASC) VISIBLE,
  CONSTRAINT `fk_detalle_compra_producto1`
    FOREIGN KEY (`id_producto`)
    REFERENCES `maxikiosko`.`producto` (`id_producto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_compra_proveedor1`
    FOREIGN KEY (`cuit`)
    REFERENCES `maxikiosko`.`proveedor` (`cuit`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `maxikiosko`.`compra`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`compra`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`compra` (
  `id_compra` INT UNSIGNED NOT NULL,
  `fecha_hora` DATE NULL,
  `proveedor_cuit` BIGINT UNSIGNED NOT NULL,
  `id_usuario` INT NOT NULL,
  `id_detalle_compra` INT NOT NULL,
  PRIMARY KEY (`id_compra`, `proveedor_cuit`, `id_usuario`, `id_detalle_compra`),
  INDEX `fk_compra_proveedor1_idx` (`proveedor_cuit` ASC) VISIBLE,
  INDEX `fk_compra_usuario1_idx` (`id_usuario` ASC) VISIBLE,
  INDEX `fk_compra_detalle_compra1_idx` (`id_detalle_compra` ASC) VISIBLE,
  CONSTRAINT `fk_compra_proveedor1`
    FOREIGN KEY (`proveedor_cuit`)
    REFERENCES `maxikiosko`.`proveedor` (`cuit`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_compra_usuario1`
    FOREIGN KEY (`id_usuario`)
    REFERENCES `maxikiosko`.`usuario` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_compra_detalle_compra1`
    FOREIGN KEY (`id_detalle_compra`)
    REFERENCES `maxikiosko`.`detalle_compra` (`id_detalle_compra`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `maxikiosko`.`movimiento_cuenta_corriente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `maxikiosko`.`movimiento_cuenta_corriente`;
CREATE TABLE IF NOT EXISTS `maxikiosko`.`movimiento_cuenta_corriente` (
  `id_movimiento` INT NOT NULL,
  `fecha_hora` DATE NULL,
  `descripcion` VARCHAR(200) NULL,
  `monto` FLOAT NULL,
  `id_cuenta` INT UNSIGNED NOT NULL,
  `id_detalle_venta` INT NOT NULL,
  `id_usuario` INT NOT NULL,
  PRIMARY KEY (`id_movimiento`, `id_cuenta`, `id_detalle_venta`, `id_usuario`),
  INDEX `fk_movimiento_cuenta_corriente_cuenta_corriente1_idx` (`id_cuenta` ASC) VISIBLE,
  INDEX `fk_movimiento_cuenta_corriente_venta1_idx` (`id_detalle_venta` ASC) VISIBLE,
  INDEX `fk_movimiento_cuenta_corriente_usuario1_idx` (`id_usuario` ASC) VISIBLE,
  CONSTRAINT `fk_movimiento_cuenta_corriente_cuenta_corriente1`
    FOREIGN KEY (`id_cuenta`)
    REFERENCES `maxikiosko`.`cuenta_corriente` (`id_cuenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimiento_cuenta_corriente_venta1`
    FOREIGN KEY (`id_detalle_venta`)
    REFERENCES `maxikiosko`.`venta` (`id_detalle_venta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimiento_cuenta_corriente_usuario1`
    FOREIGN KEY (`id_usuario`)
    REFERENCES `maxikiosko`.`usuario` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
