DROP TABLE IF EXISTS LIEU;  -- TABLE fait

DROP TABLE IF EXISTS POSITION;

DROP TABLE IF EXISTS TYPE_LIEU; --Exemple : montagne, lac, cascade, etc. 

DROP TABLE IF EXISTS PAYS;

DROP TABLE IF EXISTS CANTON;

DROP TABLE IF EXISTS COMMUNE;


# -----------------------------------------------------------------------------
#       TABLE : COMMUNE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS COMMUNE
(
   COMMUNE_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   NOM VARCHAR(20)  ,
   CODE_POSTALE INTEGER(7)  ,
   PRIMARY KEY (COMMUNE_ID)
);


# -----------------------------------------------------------------------------
#       TABLE : CANTON
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CANTON
(
   CANTON_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   NOM VARCHAR(20)  ,
   CODE_NOM VARCHAR(2)  , -- Exemple : GE, VD, etc.
   PRIMARY KEY (CANTON_ID)
);



# -----------------------------------------------------------------------------
#       TABLE : PAYS
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PAYS
(
   PAYS_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   NOM VARCHAR(20)  ,
   PRIMARY KEY (PAYS_ID)
);



# -----------------------------------------------------------------------------
#       TABLE : TYPE_LIEU
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE_LIEU
(
   TYPE_LIEU_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   NOM VARCHAR(20)  ,
   PRIMARY KEY (TYPE_LIEU_ID)
);



# -----------------------------------------------------------------------------
#       TABLE : POSITION
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS POSITION
(
   POSITION_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   LATITUDE DECIMAL(10)  , -- EN DEGRÉ DÉCIMAUX (PEUT ÊTRE NÉGATIF)
   LONGITUDE DECIMAL(10)  ,-- EN DEGRÉ DÉCIMAUX (PEUT ÊTRE NÉGATIF)
   PRIMARY KEY (POSITION_ID)
);



# -----------------------------------------------------------------------------
#       TABLE : LIEU
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LIEU
(
   LIEU_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   FK_POSITION_ID  INTEGER NOT NULL  ,
   TYPE FK_TYPE_LIEU IS VARRAY(10) OF TYPE_LIEU.TYPE_LIEU_ID%TYPE,  -- Liste des types de lieu
   FK_PAYS_ID INTEGER  ,  -- NOT NULL  ,
   FK_CANTON_ID INTEGER  ,  -- NOT NULL  ,
   FK_COMMUNE_ID INTEGER  ,  -- NOT NULL  ,
   LIEU_NOM VARCHAR(60) NOT NULL  ,
   LIEU_DESCRIPTION_LIEU VARCHAR(500) NOT NULL  ,
   LIEU_STATUT INTEGER NOT NULL  , -- 0 = inactif, 1 = actif, 2 = en attente
   TYPE PHOTO IS VARRAY(10) OF VARCHAR(100),  -- Liste de photos
   PRIMARY KEY (LIEU_ID)
);

ALTER TABLE LIEU
  ADD FOREIGN KEY (FK_POSITION_ID)
      REFERENCES POSITION (POSITION_ID) ;
      
-- Je sais pas comment faire avec les VARRAY et je sais pas s'il y en a besoin
      
ALTER TABLE LIEU
  ADD FOREIGN KEY (FK_PAYS_ID)
      REFERENCES PAYS (PAYS_ID) ;

ALTER TABLE LIEU
  ADD FOREIGN KEY (FK_CANTON_ID)
      REFERENCES CANTON (CANTON_ID) ;

ALTER TABLE LIEU
  ADD FOREIGN KEY (FK_COMMUNE_ID)
      REFERENCES COMMUNE (COMMUNE_ID) ;
      
      

# -----------------------------------------------------------------------------
#      INSERTIONS
# -----------------------------------------------------------------------------

INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Genève', 1201);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Genève', 1202);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Genève', 1203);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Champel', 1204);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Champel', 1205);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Champel', 1206);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Genève', 1207);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Genève', 1208);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Vernier', 1209);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Grand-Lancy', 1212);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Lancy-Onex', 1213);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Vernier', 1214);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Cointrin', 1216);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Meyrin', 1217);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Grand-Saconnex', 1218);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Vernier', 1219);  -- Le Lignon, Aïre, Châtelaine
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Avanchets', 1220);
INSERT INTO `COMMUNE`(`NOM`, `CODE_POSTALE`) VALUES ('Vésenaz', 1222);
-- à mettre la suite déso pas le courage et je pense qu'on peut trouvé comment mettre automatiquement comme on en avait parlé

