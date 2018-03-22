
CREATE TABLE tipo_personal (
                id_tipo INT NOT NULL,
                tipop_nombre VARCHAR(30) NOT NULL,
                CONSTRAINT tipo_personal_pk PRIMARY KEY (id_tipo)
)

CREATE TABLE bodega (
                id_bodega INT NOT NULL,
                nombre_bodega VARCHAR(30) NOT NULL,
                direccion_bodega VARCHAR(30),
                obs_bodega VARCHAR(30),
                CONSTRAINT bodega_pk PRIMARY KEY (id_bodega)
)

CREATE TABLE personal (
                id_personal INT IDENTITY NOT NULL,
                nombre_personal VARCHAR(30) NOT NULL,
                id_tipo INT NOT NULL,
                CONSTRAINT personal_pk PRIMARY KEY (id_personal)
)

CREATE TABLE zonas (
                id_zona INT IDENTITY NOT NULL,
                nombre_zona VARCHAR(30) NOT NULL,
                CONSTRAINT zonas_pk PRIMARY KEY (id_zona)
)

CREATE TABLE zonas_personal (
                id_zonas_personal VARCHAR(30) NOT NULL,
                id_zona INT NOT NULL,
                id_personal INT NOT NULL,
                CONSTRAINT zonas_personal_pk PRIMARY KEY (id_zonas_personal)
)

CREATE TABLE articulos (
                id_articulo INT IDENTITY NOT NULL,
                nombre_articulo VARCHAR(30) NOT NULL,
                id_bodega INT NOT NULL,
                CONSTRAINT articulos_pk PRIMARY KEY (id_articulo)
)

CREATE TABLE cards (
                id VARCHAR(30) NOT NULL,
                nombre VARCHAR(30) NOT NULL,
                direccion VARCHAR(30),
                barrio VARCHAR(30),
                valor_total INT NOT NULL,
                is_open BIT NOT NULL,
                obs VARCHAR(30),
                modo_pago VARCHAR(30) NOT NULL,
                id_vendedor INT NOT NULL,
                id_cobrador INT NOT NULL,
                CONSTRAINT cards_pk PRIMARY KEY (id)
)

CREATE TABLE articulos_detalle (
                id_articulos_detalle INT IDENTITY NOT NULL,
                id_articulo INT NOT NULL,
                articulo_detalle_cantidad INT NOT NULL,
                id_card VARCHAR(30) NOT NULL,
                CONSTRAINT articulos_detalle_pk PRIMARY KEY (id_articulos_detalle)
)

CREATE TABLE pagos (
                id_pago INT IDENTITY NOT NULL,
                id_card VARCHAR(30) NOT NULL,
                pago_fecha DATETIME NOT NULL,
                monto INT NOT NULL,
                CONSTRAINT pagos_pk PRIMARY KEY (id_pago)
)

ALTER TABLE personal ADD CONSTRAINT tipo_personal_personal_fk
FOREIGN KEY (id_tipo)
REFERENCES tipo_personal (id_tipo)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE articulos ADD CONSTRAINT bodega_articulos_fk
FOREIGN KEY (id_bodega)
REFERENCES bodega (id_bodega)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE zonas_personal ADD CONSTRAINT personal_zonas_vendedor_fk
FOREIGN KEY (id_personal)
REFERENCES personal (id_personal)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE cards ADD CONSTRAINT personal_cards_fk
FOREIGN KEY (id_vendedor)
REFERENCES personal (id_personal)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE cards ADD CONSTRAINT personal_cards_fk1
FOREIGN KEY (id_cobrador)
REFERENCES personal (id_personal)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE zonas_personal ADD CONSTRAINT zonas_zonas_vendedor_fk
FOREIGN KEY (id_zona)
REFERENCES zonas (id_zona)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE articulos_detalle ADD CONSTRAINT articulos_articulos_detalle_fk
FOREIGN KEY (id_articulo)
REFERENCES articulos (id_articulo)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE pagos ADD CONSTRAINT cards_pagos_fk
FOREIGN KEY (id_card)
REFERENCES cards (id)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE articulos_detalle ADD CONSTRAINT cards_articulos_detalle_fk
FOREIGN KEY (id_card)
REFERENCES cards (id)
ON DELETE NO ACTION
ON UPDATE NO ACTION