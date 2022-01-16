DROP TABLE IF EXISTS CONSULTE;

DROP TABLE IF EXISTS CONTIENT;

DROP TABLE IF EXISTS GERE;

DROP TABLE IF EXISTS CORRESPOND;

DROP TABLE IF EXISTS CONCERNE;

DROP TABLE IF EXISTS COMPREND;

DROP TABLE IF EXISTS A_LIEU;

DROP TABLE IF EXISTS FACTURE;

DROP TABLE IF EXISTS DEVIS;

DROP TABLE IF EXISTS FICHIERVIDEO;

DROP TABLE IF EXISTS PHOTO;

DROP TABLE IF EXISTS CONTRAT;

DROP TABLE IF EXISTS DOCUMENT;

DROP TABLE IF EXISTS LIEU;

DROP TABLE IF EXISTS RESERVATION;

DROP TABLE IF EXISTS PROJET;

DROP TABLE IF EXISTS CLIENT;

DROP TABLE IF EXISTS COLLABORATEUR;

DROP TABLE IF EXISTS CLIENT;

DROP TABLE IF EXISTS MATERIEL;

DROP TABLE IF EXISTS PHOTOGRAPHE;

DROP TABLE IF EXISTS PERSONNE;

DROP TABLE IF EXISTS DATE;

DROP TABLE IF EXISTS CRITERE;

DROP TABLE IF EXISTS EVENEMENT;

DROP TABLE IF EXISTS CATEGORIE;

# -----------------------------------------------------------------------------
#       TABLE : PERSONNE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PERSONNE
 (
   PERSONNE_ID INTEGER NOT NULL  ,
   PERSONNE_NOM VARCHAR(60) NOT NULL  ,
   PERSONNE_PRENOM VARCHAR(50) NOT NULL  ,
   PERSONNE_MAIL VARCHAR(255) NOT NULL  ,
   PERSONNE_MDP VARCHAR(40) NOT NULL  ,
   PERSONNE_TEL BIGINT(14) NOT NULL  
   , PRIMARY KEY (PERSONNE_ID) 
 );

# -----------------------------------------------------------------------------
#       TABLE : DATE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DATE
 (
   DATE_ID INTEGER NOT NULL  ,
   DATE_DATE DATE NULL  ,
   DATE_HEURE DATE NULL  
   , PRIMARY KEY (DATE_ID) 
 );

# -----------------------------------------------------------------------------
#       TABLE : EVENEMENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EVENEMENT
 (
   EVENEMENT_ID INTEGER NOT NULL  
   , PRIMARY KEY (EVENEMENT_ID) 
 );

# -----------------------------------------------------------------------------
#       TABLE : CATEGORIE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CATEGORIE
 (
   CATEGORIE_ID INTEGER NOT NULL  ,
   CATEGORIE_NOM VARCHAR(128) NOT NULL  
   , PRIMARY KEY (CATEGORIE_ID) 
 ) ;


# -----------------------------------------------------------------------------
#       TABLE : CRITERE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CRITERE
 (
   CRITERE_ID INTEGER NOT NULL  ,
   CRITERE_NOM VARCHAR(40) NOT NULL  
   , PRIMARY KEY (CRITERE_ID) 
 );

# -----------------------------------------------------------------------------
#       TABLE : PHOTOGRAPHE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PHOTOGRAPHE
 (
   PHOTOGRAPHE_ID INTEGER NOT NULL  ,
   FK_PERSONNE_ID INTEGER NOT NULL  
   , PRIMARY KEY (PHOTOGRAPHE_ID) 
 );

ALTER TABLE PHOTOGRAPHE 
  ADD FOREIGN KEY (FK_PERSONNE_ID) 
      REFERENCES PERSONNE (PERSONNE_ID) ;

# -----------------------------------------------------------------------------
#       TABLE : MATERIEL
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS MATERIEL
 (
   MATERIEL_ID INTEGER NOT NULL  ,
   FK_CATEGORIE_ID INTEGER NOT NULL  ,
   MATERIEL_NOM VARCHAR(128) NOT NULL  ,
   MATERIEL_DESCRIPTION VARCHAR(255) NULL  ,
   MATERIEL_PRIX DECIMAL(10,2) NULL  ,
   MATERIEL_QUANTITE INTEGER NOT NULL  
   , PRIMARY KEY (MATERIEL_ID) 
 ) ;


ALTER TABLE MATERIEL 
  ADD FOREIGN KEY (FK_CATEGORIE_ID)
      REFERENCES CATEGORIE (CATEGORIE_ID) ;

# -----------------------------------------------------------------------------
#       TABLE : COLLABORATEUR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS COLLABORATEUR
 (
   COLLABORATEUR_ID INTEGER NOT NULL  ,
   FK_PERSONNE_ID INTEGER NOT NULL  
   , PRIMARY KEY (COLLABORATEUR_ID) 
 );

ALTER TABLE COLLABORATEUR 
  ADD FOREIGN KEY (FK_PERSONNE_ID) 
      REFERENCES PERSONNE (PERSONNE_ID) ;

# -----------------------------------------------------------------------------
#       TABLE : CLIENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CLIENT
 (
   CLIENT_ID INTEGER NOT NULL  ,
   FK_PERSONNE_ID INTEGER NOT NULL  ,
   CLIENT_VALIDER INTEGER NOT NULL  
      DEFAULT FALSE
   , PRIMARY KEY (CLIENT_ID) 
 );

ALTER TABLE CLIENT 
  ADD FOREIGN KEY (FK_PERSONNE_ID) 
      REFERENCES PERSONNE (PERSONNE_ID) ;


# -----------------------------------------------------------------------------
#       TABLE : PROJET
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PROJET
 (
   PROJET_ID INTEGER NOT NULL  ,
   FK_CLIENT_ID INTEGER NOT NULL  ,
   PROJET_NOM VARCHAR(60) NOT NULL  ,
   PROJET_DESCRIPTION VARCHAR(255) NOT NULL  ,
   PROJET_VALIDER INTEGER NOT NULL  
      DEFAULT FALSE
   , PRIMARY KEY (PROJET_ID) 
 );


ALTER TABLE PROJET
  ADD FOREIGN KEY (FK_CLIENT_ID) 
      REFERENCES CLIENT (CLIENT_ID) ;

# -----------------------------------------------------------------------------
#       TABLE : LIEU
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LIEU
 (
   LIEU_ID INTEGER NOT NULL  ,
   LIEU_NOM VARCHAR(60) NOT NULL  ,
   LIEU_LONGITUDE VARCHAR(80) NOT NULL  ,
   LIEU_LATITUDE VARCHAR(80) NOT NULL  ,
   LIEU_CRITERE VARCHAR(40) NOT NULL  ,
   LIEU_DESCRIPTION VARCHAR(255) NOT NULL  
   , PRIMARY KEY (LIEU_ID) 
 );

# -----------------------------------------------------------------------------
#       TABLE : RESERVATION
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS RESERVATION
 (
   RESERVATION_ID INTEGER NOT NULL  ,
   FK_PROJET_ID INTEGER NOT NULL  ,
   RESERVATION_QUANTITE INTEGER NOT NULL  ,
   RESERVATION_DATE_DEBUT DATE NOT NULL  ,
   RESERVATION_DATE_FIN DATE NOT NULL  
   , PRIMARY KEY (RESERVATION_ID) 
 ) ;
 
 ALTER TABLE RESERVATION
  ADD FOREIGN KEY (FK_PROJET_ID) 
      REFERENCES PROJET (PROJET_ID) ;

# -----------------------------------------------------------------------------
#       TABLE : DOCUMENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DOCUMENT
 (
   DOCUMENT_ID INTEGER NOT NULL  ,
   FK_PROJET_ID INTEGER NOT NULL  ,
   DOCUMENT_NOM VARCHAR(60) NOT NULL  ,
   DOCUMENT_DESCRIPTION VARCHAR(255) NOT NULL  ,
   DOCUMENT_DATE DATE NULL  
   , PRIMARY KEY (DOCUMENT_ID)
 );


ALTER TABLE DOCUMENT
  ADD FOREIGN KEY (FK_PROJET_ID) 
      REFERENCES PROJET (PROJET_ID) ;




# -----------------------------------------------------------------------------
#       TABLE : FACTURE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS FACTURE
 (
   FACTURE_ID INTEGER NOT NULL  ,
   FK_DOCUMENT_ID INTEGER NOT NULL  ,
   FACTURE_VALIDER INTEGER NOT NULL  
   , PRIMARY KEY (FACTURE_ID) 
 );

ALTER TABLE FACTURE 
  ADD FOREIGN KEY (FK_DOCUMENT_ID)
      REFERENCES DOCUMENT (DOCUMENT_ID);

# -----------------------------------------------------------------------------
#       TABLE : DEVIS
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DEVIS
 (
   DEVIS_ID INTEGER NOT NULL  ,
   FK_DOCUMENT_ID INTEGER NOT NULL  ,
   DEVIS_VALIDER INTEGER NOT NULL  
   , PRIMARY KEY (DEVIS_ID) 
 );

ALTER TABLE DEVIS 
  ADD FOREIGN KEY (FK_DOCUMENT_ID)
      REFERENCES DOCUMENT (DOCUMENT_ID);

# -----------------------------------------------------------------------------
#       TABLE : FICHIERVIDEO
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS FICHIERVIDEO
 (
   FICHIERVIDEO_ID INTEGER NOT NULL  ,
   FK_LIEU_ID INTEGER NOT NULL
   , PRIMARY KEY (FICHIERVIDEO_ID) 
 );

ALTER TABLE FICHIERVIDEO
  ADD FOREIGN KEY (FK_LIEU_ID)
      REFERENCES LIEU (LIEU_ID) ;

# -----------------------------------------------------------------------------
#       TABLE : PHOTO
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PHOTO
 (
   PHOTO_ID INTEGER NOT NULL  ,
   FK_LIEU_ID INTEGER NOT NULL,
   PHOTO_DATE DATE NOT NULL  ,
   PHOTO_CHEMIN VARCHAR(255) NOT NULL  
   , PRIMARY KEY (PHOTO_ID) 
 );

ALTER TABLE PHOTO
  ADD FOREIGN KEY (FK_LIEU_ID)
      REFERENCES LIEU (LIEU_ID) ;




# -----------------------------------------------------------------------------
#       TABLE : CONTRAT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CONTRAT
 (
   CONTRAT_ID INTEGER NOT NULL  ,
   FK_DOCUMENT_ID INTEGER NOT NULL  ,
   CONTRAT_SIGNER INTEGER NOT NULL  
   , PRIMARY KEY (CONTRAT_ID) 
 );

ALTER TABLE CONTRAT 
  ADD FOREIGN KEY (FK_DOCUMENT_ID)
      REFERENCES DOCUMENT (DOCUMENT_ID);


# -----------------------------------------------------------------------------
#       TABLE : CONSULTE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CONSULTE
 (
   FK_PHOTOGRAPHE_ID INTEGER NOT NULL  ,
   FK_LIEU_ID INTEGER NOT NULL  
   , PRIMARY KEY (FK_PHOTOGRAPHE_ID,FK_LIEU_ID) 
 );

ALTER TABLE CONSULTE 
  ADD FOREIGN KEY (FK_PHOTOGRAPHE_ID) 
      REFERENCES PHOTOGRAPHE (PHOTOGRAPHE_ID) ;

ALTER TABLE CONSULTE 
  ADD FOREIGN KEY (FK_LIEU_ID) 
      REFERENCES LIEU (LIEU_ID) ;

# -----------------------------------------------------------------------------
#       TABLE : CONTIENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CONTIENT
 (
   FK_EVENEMENT_ID INTEGER NOT NULL  ,
   FK_PROJET_ID INTEGER NOT NULL  
   , PRIMARY KEY (FK_EVENEMENT_ID,FK_PROJET_ID) 
 );

ALTER TABLE CONTIENT
  ADD FOREIGN KEY (FK_EVENEMENT_ID) 
      REFERENCES EVENEMENT (EVENEMENT_ID) ;


ALTER TABLE CONTIENT
  ADD FOREIGN KEY (FK_PROJET_ID) 
      REFERENCES PROJET (PROJET_ID) ;

# -----------------------------------------------------------------------------
#       TABLE : GERE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS GERE
 (
   FK_PROJET_ID INTEGER NOT NULL  ,
   FK_COLLABORATEUR_ID INTEGER NOT NULL  
   , PRIMARY KEY (FK_PROJET_ID,FK_COLLABORATEUR_ID) 
 );

ALTER TABLE GERE 
  ADD FOREIGN KEY (FK_PROJET_ID) 
      REFERENCES PROJET (PROJET_ID) ;


ALTER TABLE GERE 
  ADD FOREIGN KEY (FK_COLLABORATEUR_ID) 
      REFERENCES COLLABORATEUR (COLLABORATEUR_ID) ;

# -----------------------------------------------------------------------------
#       TABLE : CORRESPOND
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CORRESPOND
 (
   FK_LIEU_ID INTEGER NOT NULL  ,
   FK_CRITERE_ID INTEGER NOT NULL  
   , PRIMARY KEY (FK_LIEU_ID,FK_CRITERE_ID) 
 );

ALTER TABLE CORRESPOND 
  ADD FOREIGN KEY (FK_LIEU_ID) 
      REFERENCES LIEU (LIEU_ID) ;


ALTER TABLE CORRESPOND 
  ADD FOREIGN KEY (FK_CRITERE_ID) 
      REFERENCES CRITERE (CRITERE_ID) ;

# -----------------------------------------------------------------------------
#       TABLE : CONCERNE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CONCERNE
 (
   FK_PROJET_ID INTEGER NOT NULL  ,
   FK_LIEU_ID INTEGER NOT NULL  
   , PRIMARY KEY (FK_PROJET_ID,FK_LIEU_ID) 
 );

ALTER TABLE CONCERNE 
  ADD FOREIGN KEY (FK_PROJET_ID) 
      REFERENCES PROJET (PROJET_ID) ;


ALTER TABLE CONCERNE 
  ADD FOREIGN KEY (FK_LIEU_ID) 
      REFERENCES LIEU (LIEU_ID) ;

# -----------------------------------------------------------------------------
#       TABLE : A_LIEU
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS A_LIEU
 (
   FK_PROJET_ID INTEGER NOT NULL  ,
   FK_DATE_ID INTEGER NOT NULL  
   , PRIMARY KEY (FK_PROJET_ID,FK_DATE_ID) 
 );


ALTER TABLE A_LIEU 
  ADD FOREIGN KEY (FK_PROJET_ID) 
      REFERENCES PROJET (PROJET_ID) ;


ALTER TABLE A_LIEU 
  ADD FOREIGN KEY (FK_DATE_ID) 
      REFERENCES DATE (DATE_ID) ;



# -----------------------------------------------------------------------------
#       TABLE : COMPREND
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS COMPREND
 (
   FK_RESERVATION_ID INTEGER NOT NULL  ,
   FK_MATERIEL_ID INTEGER NOT NULL  
   , PRIMARY KEY (FK_RESERVATION_ID,FK_MATERIEL_ID) 
 ) ;

ALTER TABLE COMPREND 
  ADD FOREIGN KEY (FK_RESERVATION_ID)
      REFERENCES RESERVATION (RESERVATION_ID) ;

ALTER TABLE COMPREND 
  ADD FOREIGN KEY (FK_MATERIEL_ID)
      REFERENCES MATERIEL (MATERIEL_ID) ;















