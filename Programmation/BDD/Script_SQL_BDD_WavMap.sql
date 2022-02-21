DROP TABLE IF EXISTS LIEU;  

DROP TABLE IF EXISTS POSITION;  

DROP TABLE IF EXISTS TAG;  


# -----------------------------------------------------------------------------
#       TABLE : TAG  -- on pourrait utiliser plusieurs fois un m�me tag
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TAG
(
   TAG_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   TAG_NOM VARCHAR(20)  ,
   PRIMARY KEY (TYPE_LIEU_ID)
);



# -----------------------------------------------------------------------------
#       TABLE : POSITION  -- on pourrait avoir plusieurs lieu pour une m�me position
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS POSITION
(
   POSITION_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   POSITION_LATITUDE DECIMAL(10)  , -- EN DEGR� D�CIMAUX (PEUT �TRE N�GATIF)
   POSITION_LONGITUDE DECIMAL(10)  ,-- EN DEGR� D�CIMAUX (PEUT �TRE N�GATIF)
   PRIMARY KEY (POSITION_ID)
);



# -----------------------------------------------------------------------------
#       TABLE : LIEU  -- TABLE fait
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LIEU
(
   LIEU_ID INTEGER NOT NULL AUTO_INCREMENT  ,
   FK_POSITION_ID  INTEGER NOT NULL  ,
   TYPE FK_TAG IS VARRAY(10) OF TAG.TAG_ID%TYPE,  -- Liste des types de lieu
   LIEU_NOM VARCHAR(60) NOT NULL  ,
   LIEU_DESCRIPTION VARCHAR(500) NOT NULL  ,
   LIEU_STATUT INTEGER NOT NULL  , -- 0 = inactif, 1 = actif, 2 = en attente
   TYPE LIEU_PHOTO IS VARRAY(10) OF VARCHAR(100),  -- Liste de photos
   PRIMARY KEY (LIEU_ID)
);

ALTER TABLE LIEU
  ADD FOREIGN KEY (FK_POSITION_ID)
      REFERENCES POSITION (POSITION_ID) ;
      
-- Je sais pas comment faire avec les VARRAY et je sais pas s'il y en a besoin
    
      

# -----------------------------------------------------------------------------
#      INSERTIONS
# -----------------------------------------------------------------------------


