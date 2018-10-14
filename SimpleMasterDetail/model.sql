DROP DATABASE MYPORTFOLIO
go

CREATE DATABASE MYPORTFOLIO
go

USE MYPORTFOLIO
go

CREATE TABLE GROUP_PRODUCT (
   ID_GROUP_PRODUCT     INT                  IDENTITY,
   DSC_GROUP_PRODUCT    NVARCHAR(40)         NOT NULL,
   CONSTRAINT PK_GROUP_PRODUCT PRIMARY KEY (ID_GROUP_PRODUCT)
)
go

CREATE INDEX GROUP_PRODUCT_I1 ON GROUP_PRODUCT (
DSC_GROUP_PRODUCT ASC
)
go

CREATE TABLE SUBGROUP_PRODUCT (
   ID_SUBGROUP_PRODUCT  INT                  IDENTITY,
   ID_GROUP_PRODUCT     INT                  NOT NULL,
   DSC_SUBGROUP_PRODUCT NVARCHAR(40)         NOT NULL,
   CONSTRAINT PK_SUBGROUP_PRODUCT PRIMARY KEY (ID_SUBGROUP_PRODUCT)
)
go

CREATE INDEX SUBGROUP_PRODUCT_I1 ON SUBGROUP_PRODUCT (
ID_GROUP_PRODUCT ASC
)
go

CREATE INDEX SUBGROUP_PRODUCT_I2 ON SUBGROUP_PRODUCT (
DSC_SUBGROUP_PRODUCT ASC
)
go

ALTER TABLE SUBGROUP_PRODUCT
   ADD CONSTRAINT SUBGROUP_PRD_FK_GROUP_PRD FOREIGN KEY (ID_GROUP_PRODUCT)
      REFERENCES GROUP_PRODUCT (ID_GROUP_PRODUCT)
go

