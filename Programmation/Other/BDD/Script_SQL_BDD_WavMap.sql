DROP TABLE IF EXISTS LIEU;  

DROP TABLE IF EXISTS PHOTO;

DROP TABLE IF EXISTS TAG;  

DROP TABLE IF EXISTS LIEU_HAS_TAG;

DROP TABLE IF EXISTS LIEU_HAS_PHOTO; 

DROP TABLE IF EXISTS CATEGORIE;

DROP TABLE IF EXISTS STATUT;



# -----------------------------------------------------------------------------
#       TABLE : CATEGORIE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CATEGORIE
(
   CATEGORIE_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   CATEGORIE_NOM VARCHAR(200) NOT NULL  ,
   PRIMARY KEY (CATEGORIE_ID)
);



# -----------------------------------------------------------------------------
#       TABLE : TAG
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TAG
(
   TAG_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   FK_CATEGORIE_ID INTEGER(11) NOT NULL  ,
   TAG_NOM VARCHAR(20)  ,
   PRIMARY KEY (TAG_ID)
);


ALTER TABLE TAG
   ADD FOREIGN KEY (FK_CATEGORIE_ID)
       REFERENCES CATEGORIE(CATEGORIE_ID);



# -----------------------------------------------------------------------------
#       TABLE : PHOTO 
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PHOTO
(
   PHOTO_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   PHOTO_PATH VARCHAR(100)  ,
   PRIMARY KEY (PHOTO_ID)
);


# -----------------------------------------------------------------------------
#       TABLE : STATUT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS STATUT
(
   STATUT_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   STATUT_NOM VARCHAR(200) NOT NULL  ,
   PRIMARY KEY (STATUT_ID)
);


# -----------------------------------------------------------------------------
#       TABLE : LIEU
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LIEU
(
   LIEU_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   FK_LIEU_STATUT INTEGER NOT NULL  , -- 0 = inactif, 1 = actif, 2 = en attente
   LIEU_NOM VARCHAR(60) NOT NULL  ,
   LIEU_DESCRIPTION VARCHAR(500) NOT NULL  ,
   LIEU_LATITUDE DECIMAL(10)  , -- EN DEGRÉ DÉCIMAUX (PEUT ÊTRE NÉGATIF)
   LIEU_LONGITUDE DECIMAL(10)  ,-- EN DEGRÉ DÉCIMAUX (PEUT ÊTRE NÉGATIF)
   PRIMARY KEY (LIEU_ID)
);

ALTER TABLE LIEU
   ADD FOREIGN KEY (FK_LIEU_STATUT)
       REFERENCES STATUT(STATUT_ID);


# -----------------------------------------------------------------------------
#       TABLE : LIEU_HAS_TAG
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LIEU_HAS_TAG
(
   PK_FK_LIEU_ID INTEGER NOT NULL  ,
   PK_FK_TAG_ID INTEGER NOT NULL  ,
   PRIMARY KEY (PK_FK_LIEU_ID, PK_FK_TAG_ID)
);

ALTER TABLE LIEU_HAS_TAG
   ADD FOREIGN KEY (PK_FK_LIEU_ID)
       REFERENCES LIEU(LIEU_ID);
       
ALTER TABLE LIEU_HAS_TAG
   ADD FOREIGN KEY (PK_FK_TAG_ID)
       REFERENCES TAG(TAG_ID);
       
       
# -----------------------------------------------------------------------------
#       TABLE : LIEU_HAS_PHOTO
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LIEU_HAS_PHOTO
(
   PK_FK_LIEU_ID INTEGER NOT NULL  ,
   PK_FK_PHOTO_ID INTEGER NOT NULL  ,
   PRIMARY KEY (PK_FK_LIEU_ID, PK_FK_PHOTO_ID)
);

ALTER TABLE LIEU_HAS_PHOTO
   ADD FOREIGN KEY (PK_FK_LIEU_ID)
       REFERENCES LIEU(LIEU_ID);
       
ALTER TABLE LIEU_HAS_PHOTO
   ADD FOREIGN KEY (PK_FK_PHOTO_ID)
       REFERENCES TAG(TAG_ID);
     




