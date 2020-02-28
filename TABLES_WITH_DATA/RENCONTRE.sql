--------------------------------------------------------
--  File created - Sunday-December-24-2017   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table RENCONTRE
--------------------------------------------------------

  CREATE TABLE "WORLDCUP"."RENCONTRE" 
   (	"ID" NUMBER(38,0), 
	"RCATEGORY" VARCHAR2(50 BYTE), 
	"TEAM1" VARCHAR2(50 BYTE), 
	"TEAM2" VARCHAR2(50 BYTE), 
	"SEMAINE" VARCHAR2(50 BYTE), 
	"DRAP1" VARCHAR2(50 BYTE), 
	"DRAP2" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
REM INSERTING into WORLDCUP.RENCONTRE
SET DEFINE OFF;
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (2,'A','Espagne','Russie','1','esp','rus');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (3,'A','Nigeria','CostaRica','1','nga','crc');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (4,'A','CostaRica','Russie','2','crc','rus');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (5,'A','Nigeria','Espagne','2','nga','esp');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (6,'A','Australie','Allemagne','0','aus','ger');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (7,'A','Danemark','Perou','0','den','per');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (8,'A','Perou','Allemagne','1','per','ger');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (9,'A','Australie','Danemark','1','aus','den');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (10,'A','Danemark','Allemagne','2','den','ger');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (11,'A','Australie','Perou','2','aus','per');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (12,'C','Japon','Bresil','0','jpn','bra');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (13,'C','Islande','Suisse','0','isl','sui');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (14,'C','Suisse','Bresil','1','sui','bra');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (15,'C','Japon','Islande','1','jpn','isl');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (16,'C','Islande','Bresil','2','isl','bra');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (17,'C','Japon','Suisse','2','jpn','sui');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (18,'D','Maroc','Portugal','0','mar','por');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (19,'D','Iran','Angleterre','0','irn','eng');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (20,'D','Angleterre','Portugal','1','eng','por');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (21,'D','Maroc','Iran','1','mar','irn');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (22,'D','Iran','Portugal','2','irn','por');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (23,'D','Maroc','Angleterre','2','mar','eng');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (24,'E','Serbia','Argentine','0','srb','arg');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (25,'E','Suede','Mexique','0','swe','mex');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (26,'E','Mexique','Argentine','1','mex','arg');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (27,'E','Serbia','Suede','1','srb','swe');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (28,'E','Suede','Argentine','2','swe','arg');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (29,'E','Serbia','Mexique','2','srb','mex');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (30,'F','Panama','Belgique','0','pan','bel');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (31,'F','Tunisie','Colombia','0','tun','col');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (32,'F','Colombia','Belgique','1','col','bel');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (33,'F','Panama','Tunisie','1','pan','tun');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (34,'F','Tunisie','Belgique','2','tun','bel');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (35,'F','Panama','Colombia','2','pan','col');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (36,'G','KoreaRep','Poland','0','kor','pol');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (37,'G','Egypte','Uruguay','0','egy','uru');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (38,'G','Uruguay','Poland','1','uru','pol');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (39,'G','KoreaRep','Egypte','1','kor','egy');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (40,'G','Egypte','Poland','2','egy','pol');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (41,'G','KoreaRep','Uruguay','2','kor','uru');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (42,'H','A_Saoudite','France','0','ksa','fra');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (43,'H','Senegal','Croatie','0','sen','cro');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (44,'H','Croatie','France','1','cro','fra');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (45,'H','A_Saoudite','Senegal','1','ksa','sen');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (46,'H','Senegal','France','2','sen','fra');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (47,'H','A_Saoudite','Croatie','2','ksa','cro');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (0,'A','Nigeria','Russie','0','nga','rus');
Insert into WORLDCUP.RENCONTRE (ID,RCATEGORY,TEAM1,TEAM2,SEMAINE,DRAP1,DRAP2) values (1,'A','CostaRica','Espagne','0','crc','esp');
