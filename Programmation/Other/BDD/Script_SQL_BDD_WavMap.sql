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
   NB_SELECTION INTEGER(11) NOT NULL DEFAULT 0  ,
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
   LIEU_LATITUDE DECIMAL(10)  , -- EN DEGR� D�CIMAUX (PEUT �TRE N�GATIF)
   LIEU_LONGITUDE DECIMAL(10)  ,-- EN DEGR� D�CIMAUX (PEUT �TRE N�GATIF)
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


# -----------------------------------------------------------------------------
#      INSERTIONS
# -----------------------------------------------------------------------------
# -----------------------------------------------------------------------------
#       TABLE : CATEGORIE
# -----------------------------------------------------------------------------
INSERT INTO `CATEGORIE`(`CATEGORIE_NOM`) VALUES ('Nature');
INSERT INTO `CATEGORIE`(`CATEGORIE_NOM`) VALUES ('Urban');
INSERT INTO `CATEGORIE`(`CATEGORIE_NOM`) VALUES ('Evènement');


# -----------------------------------------------------------------------------
#       TABLE : STATUT
# -----------------------------------------------------------------------------
INSERT INTO `STATUT`(`STATUT_NOM`) VALUES ('Inactif');
INSERT INTO `STATUT`(`STATUT_NOM`) VALUES ('Actif');
INSERT INTO `STATUT`(`STATUT_NOM`) VALUES ('Caché');


# -----------------------------------------------------------------------------
#       TABLE : TAG
# -----------------------------------------------------------------------------
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (1, 'Mer', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (1, 'Forêt', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (1, 'Fleuve', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (2, 'Maison', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (2, 'Villa', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (2, 'Piscine', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (2, 'Route', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (3, 'Mariage', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (3, 'Anniversaire', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (3, 'Fête', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELETION`) VALUES (1, 'Arbre', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (1, 'Sapin', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (1, 'Champ', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (3, 'Paradis', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (2, 'Entreprise', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (2, 'Bâtiment', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (2, 'Ecole', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (2, 'Monument', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (1, 'Lac', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (1, 'Plage', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (1, 'Montagne', 0);
INSERT INTO `TAG`(`FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES (1, 'Parc', 0);


# -----------------------------------------------------------------------------
#       TABLE : LIEU
# -----------------------------------------------------------------------------
INSERT INTO `LIEU`(`FK_LIEU_STATUT`, `LIEU_NOM`, `LIEU_DESCRIPTION`, `LIEU_LAT`, `LIEU_LON`) VALUES (2, 'Waview SNC', 'Une entreprise de production audio visuelle', '46.22035712513052', '6.0792356990189');
INSERT INTO `LIEU`(`FK_LIEU_STATUT`, `LIEU_NOM`, `LIEU_DESCRIPTION`, `LIEU_LAT`, `LIEU_LON`) VALUES (2, 'HEG', 'La Haute école de gestion de Genève (HEG) est une école de niveau universitaire spécialisée dans le domaine commercial. Cette école est rattachée à la HES-SO.', '46.174807', '6.139837');
INSERT INTO `LIEU`(`FK_LIEU_STATUT`, `LIEU_NOM`, `LIEU_DESCRIPTION`, `LIEU_LAT`, `LIEU_LON`) VALUES (2, 'Jet d\'eau de Genève', 'Le jet deau de Genève est un monument emblématique du canton de Genève. Il mesure 140 mètres et se situe sur la rade dans le lac Léman. C\'est un lieu touristique depuis sa création en 1891.', '46.206020', '6.157360');
INSERT INTO `LIEU`(`FK_LIEU_STATUT`, `LIEU_NOM`, `LIEU_DESCRIPTION`, `LIEU_LAT`, `LIEU_LON`) VALUES (2, 'Parc de la Nymphe', 'Ce parc se trouve à Collonge-Bellerive. Le nom de ce parc est donné par la statut se trouvant dans le lac : la nymphe.', '46.259176', '6.196433');
INSERT INTO `LIEU`(`FK_LIEU_STATUT`, `LIEU_NOM`, `LIEU_DESCRIPTION`, `LIEU_LAT`, `LIEU_LON`) VALUES (2, 'Plage des Eaux-Vives', 'Cette plage se trouve au coeur de la ville dans le quartier des Eaux-Vives. Conviviale et gratuite, cette réelle oasis au cœur de la ville comprenant 400 mètres de plage et un parc de deux hectares accolé à une zone nature est le lieu idéal pour les baigneurs et promeneurs.', '46.2086821', '6.1611387');


# -----------------------------------------------------------------------------
#       TABLE : LIEU_HAS_TAG
# -----------------------------------------------------------------------------
INSERT INTO `LIEU_HAS_TAG`(`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES (1, 14);
INSERT INTO `LIEU_HAS_TAG`(`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES (1, 15);
INSERT INTO `LIEU_HAS_TAG`(`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES (2, 14);
INSERT INTO `LIEU_HAS_TAG`(`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES (2, 17);
INSERT INTO `LIEU_HAS_TAG`(`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES (3, 18);
INSERT INTO `LIEU_HAS_TAG`(`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES (3, 19);
INSERT INTO `LIEU_HAS_TAG`(`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES (4, 19);
INSERT INTO `LIEU_HAS_TAG`(`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES (4, 22);
INSERT INTO `LIEU_HAS_TAG`(`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES (5, 11);
INSERT INTO `LIEU_HAS_TAG`(`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES (5, 19);
INSERT INTO `LIEU_HAS_TAG`(`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES (5, 20);
INSERT INTO `LIEU_HAS_TAG`(`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES (5, 22);
