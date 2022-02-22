DROP TABLE IF EXISTS LIEU;  

DROP TABLE IF EXISTS PHOTO;

DROP TABLE IF EXISTS TAG;  

DROP TABLE IF EXISTS LIEU_HAS_TAG;

DROP TABLE IF EXISTS LIEU_HAS_PHOTO; 



# -----------------------------------------------------------------------------
#       TABLE : TAG
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TAG
(
   TAG_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   TAG_NOM VARCHAR(20)  ,
   PRIMARY KEY (TYPE_LIEU_ID)
);



# -----------------------------------------------------------------------------
#       TABLE : PHOTO 
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PHOTO
(
   PHOTO_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   PHOTO_PATH VARCHAR(100)  ,
   PRIMARY KEY (POSITION_ID)
);



# -----------------------------------------------------------------------------
#       TABLE : LIEU
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LIEU
(
   LIEU_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   LIEU_NOM VARCHAR(60) NOT NULL  ,
   LIEU_DESCRIPTION VARCHAR(500) NOT NULL  ,
   LIEU_LATITUDE DECIMAL(10)  , -- EN DEGRÉ DÉCIMAUX (PEUT ÊTRE NÉGATIF)
   LIEU_LONGITUDE DECIMAL(10)  ,-- EN DEGRÉ DÉCIMAUX (PEUT ÊTRE NÉGATIF)
   LIEU_STATUT INTEGER NOT NULL  , -- 0 = inactif, 1 = actif, 2 = en attente
   PRIMARY KEY (LIEU_ID)
);


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
       REFERENCES LIEU(PK_FK_LIEU_ID);
       
ALTER TABLE LIEU_HAS_TAG
   ADD FOREIGN KEY (PK_FK_TAG_ID)
       REFERENCES TAG(PK_FK_LIEU_ID);
       
       
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
       REFERENCES LIEU(PK_FK_LIEU_ID);
       
ALTER TABLE LIEU_HAS_PHOTO
   ADD FOREIGN KEY (PK_FK_PHOTO_ID)
       REFERENCES TAG(PK_FK_LIEU_ID);
     

# -----------------------------------------------------------------------------
#      INSERTIONS
# -----------------------------------------------------------------------------


