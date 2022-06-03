-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Hôte : waview.ch.mysql.service.one.com:3306
-- Généré le : ven. 03 juin 2022 à 01:04
-- Version du serveur : 10.3.34-MariaDB-1:10.3.34+maria~focal
-- Version de PHP : 7.2.24-0ubuntu0.18.04.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `waview_chwavemap`
--
CREATE DATABASE IF NOT EXISTS `waview_chwavemap` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `waview_chwavemap`;

-- --------------------------------------------------------

--
-- Structure de la table `CATEGORIE`
--

CREATE TABLE `CATEGORIE` (
  `CATEGORIE_ID` int(11) NOT NULL,
  `CATEGORIE_NOM` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `CATEGORIE`
--

INSERT INTO `CATEGORIE` (`CATEGORIE_ID`, `CATEGORIE_NOM`) VALUES
(3, 'Évènement '),
(1, 'Nature'),
(2, 'Urban');

-- --------------------------------------------------------

--
-- Structure de la table `LIEU`
--

CREATE TABLE `LIEU` (
  `LIEU_ID` int(11) NOT NULL,
  `FK_LIEU_STATUT` int(11) NOT NULL,
  `LIEU_NOM` varchar(60) NOT NULL,
  `LIEU_DESCRIPTION` varchar(500) NOT NULL,
  `LIEU_LAT` varchar(100) NOT NULL,
  `LIEU_LON` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `LIEU`
--

INSERT INTO `LIEU` (`LIEU_ID`, `FK_LIEU_STATUT`, `LIEU_NOM`, `LIEU_DESCRIPTION`, `LIEU_LAT`, `LIEU_LON`) VALUES
(169, 2, 'Haute école de gestion de genève', 'Un bâtiment moderne', '46.175543', '6.139088'),
(170, 2, 'Waview snc', 'Une entreprise de production audiovisuelle', '46.22051', '6.07925'),
(171, 2, 'Jet d\'eau de genève', 'Plus grand fontaine a eau du monde, le jet d\'eau et le momument genevois par excellence', '46.20990', '6.15543'),
(172, 2, 'Salève', 'Wallah c\'est le salève', '0', '0');

-- --------------------------------------------------------

--
-- Structure de la table `LIEU_HAS_PHOTO`
--

CREATE TABLE `LIEU_HAS_PHOTO` (
  `PK_FK_LIEU_ID` int(11) NOT NULL,
  `PK_FK_PHOTO_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `LIEU_HAS_PHOTO`
--

INSERT INTO `LIEU_HAS_PHOTO` (`PK_FK_LIEU_ID`, `PK_FK_PHOTO_ID`) VALUES
(169, 151),
(170, 152),
(171, 153),
(172, 154);

-- --------------------------------------------------------

--
-- Structure de la table `LIEU_HAS_TAG`
--

CREATE TABLE `LIEU_HAS_TAG` (
  `PK_FK_LIEU_ID` int(11) NOT NULL,
  `PK_FK_TAG_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `LIEU_HAS_TAG`
--

INSERT INTO `LIEU_HAS_TAG` (`PK_FK_LIEU_ID`, `PK_FK_TAG_ID`) VALUES
(169, 16),
(170, 14),
(170, 15),
(170, 16),
(171, 18),
(171, 19),
(172, 2),
(172, 4),
(172, 5),
(172, 7),
(172, 10),
(172, 11),
(172, 12),
(172, 13),
(172, 14),
(172, 25),
(172, 26);

-- --------------------------------------------------------

--
-- Structure de la table `PHOTO`
--

CREATE TABLE `PHOTO` (
  `PHOTO_ID` int(11) NOT NULL,
  `PHOTO_PATH` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `PHOTO`
--

INSERT INTO `PHOTO` (`PHOTO_ID`, `PHOTO_PATH`) VALUES
(151, 'HEG-Battelle-1.jpg'),
(152, 'waview.png'),
(153, 'lieux-jet-d-eau-ville-geneve-cover.jpg'),
(154, '');

-- --------------------------------------------------------

--
-- Structure de la table `PROJECT_HAS_LIEU`
--

CREATE TABLE `PROJECT_HAS_LIEU` (
  `PK_FK_PROJECT_ID` int(11) NOT NULL,
  `PK_FK_LIEU_ID` int(11) NOT NULL,
  `PK_FK_TOURNAGE_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `PROJECT_HAS_LIEU`
--

INSERT INTO `PROJECT_HAS_LIEU` (`PK_FK_PROJECT_ID`, `PK_FK_LIEU_ID`, `PK_FK_TOURNAGE_ID`) VALUES
(27, 169, 27),
(27, 170, 29),
(28, 171, 28);

-- --------------------------------------------------------

--
-- Structure de la table `STATUT`
--

CREATE TABLE `STATUT` (
  `STATUT_ID` int(11) NOT NULL,
  `STATUT_NOM` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `STATUT`
--

INSERT INTO `STATUT` (`STATUT_ID`, `STATUT_NOM`) VALUES
(2, 'Actif'),
(1, 'Inactif'),
(3, 'Validation');

-- --------------------------------------------------------

--
-- Structure de la table `TAG`
--

CREATE TABLE `TAG` (
  `TAG_ID` int(11) NOT NULL,
  `FK_CATEGORIE_ID` int(11) NOT NULL,
  `TAG_NOM` varchar(20) NOT NULL,
  `NB_SELECTION` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `TAG`
--

INSERT INTO `TAG` (`TAG_ID`, `FK_CATEGORIE_ID`, `TAG_NOM`, `NB_SELECTION`) VALUES
(1, 1, 'Mer', 10),
(2, 1, 'Forêt', 19),
(3, 1, 'Fleuve', 7),
(4, 2, 'Maison', 2),
(5, 2, 'Villa', 0),
(6, 2, 'Piscine', 3),
(7, 2, 'Route', 2),
(8, 3, 'Mariage', 55),
(9, 3, 'Anniversaire ', 0),
(10, 3, 'Fête', 63),
(11, 1, 'Arbre', 9),
(12, 1, 'Sapin', 0),
(13, 1, 'Champ', 16),
(14, 3, 'Paradis', 49),
(15, 2, 'Entreprise', 1),
(16, 2, 'Bâtiment', 31),
(17, 2, 'Ecole', 1),
(18, 2, 'Monument', 5),
(19, 1, 'Lac', 24),
(24, 1, 'Plage', 26),
(25, 1, 'Montagne', 26),
(26, 1, 'Parc', 4);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `CATEGORIE`
--
ALTER TABLE `CATEGORIE`
  ADD PRIMARY KEY (`CATEGORIE_ID`),
  ADD UNIQUE KEY `UniqueCategorieNom` (`CATEGORIE_NOM`);

--
-- Index pour la table `LIEU`
--
ALTER TABLE `LIEU`
  ADD PRIMARY KEY (`LIEU_ID`),
  ADD UNIQUE KEY `uniqueLieu` (`LIEU_NOM`,`LIEU_LAT`,`LIEU_LON`),
  ADD KEY `FK_LIEU_STATUT` (`FK_LIEU_STATUT`) USING BTREE;

--
-- Index pour la table `LIEU_HAS_PHOTO`
--
ALTER TABLE `LIEU_HAS_PHOTO`
  ADD PRIMARY KEY (`PK_FK_LIEU_ID`,`PK_FK_PHOTO_ID`),
  ADD KEY `PK_FK_PHOTO_ID` (`PK_FK_PHOTO_ID`) USING BTREE,
  ADD KEY `PK_FK_LIEU_ID` (`PK_FK_LIEU_ID`);

--
-- Index pour la table `LIEU_HAS_TAG`
--
ALTER TABLE `LIEU_HAS_TAG`
  ADD PRIMARY KEY (`PK_FK_LIEU_ID`,`PK_FK_TAG_ID`),
  ADD KEY `PK_FK_LIEU_ID` (`PK_FK_LIEU_ID`),
  ADD KEY `LIEU_HAS_TAG_ibfk_2` (`PK_FK_TAG_ID`);

--
-- Index pour la table `PHOTO`
--
ALTER TABLE `PHOTO`
  ADD PRIMARY KEY (`PHOTO_ID`);

--
-- Index pour la table `PROJECT_HAS_LIEU`
--
ALTER TABLE `PROJECT_HAS_LIEU`
  ADD PRIMARY KEY (`PK_FK_PROJECT_ID`,`PK_FK_LIEU_ID`,`PK_FK_TOURNAGE_ID`),
  ADD KEY `FOREIGN KEY LIEU ID` (`PK_FK_LIEU_ID`);

--
-- Index pour la table `STATUT`
--
ALTER TABLE `STATUT`
  ADD PRIMARY KEY (`STATUT_ID`),
  ADD UNIQUE KEY `UniqueStatutNom` (`STATUT_NOM`);

--
-- Index pour la table `TAG`
--
ALTER TABLE `TAG`
  ADD PRIMARY KEY (`TAG_ID`),
  ADD UNIQUE KEY `uniqueTagNom` (`TAG_NOM`),
  ADD KEY `categorie` (`FK_CATEGORIE_ID`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `CATEGORIE`
--
ALTER TABLE `CATEGORIE`
  MODIFY `CATEGORIE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT pour la table `LIEU`
--
ALTER TABLE `LIEU`
  MODIFY `LIEU_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=173;

--
-- AUTO_INCREMENT pour la table `PHOTO`
--
ALTER TABLE `PHOTO`
  MODIFY `PHOTO_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=155;

--
-- AUTO_INCREMENT pour la table `STATUT`
--
ALTER TABLE `STATUT`
  MODIFY `STATUT_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `TAG`
--
ALTER TABLE `TAG`
  MODIFY `TAG_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `LIEU`
--
ALTER TABLE `LIEU`
  ADD CONSTRAINT `satu` FOREIGN KEY (`FK_LIEU_STATUT`) REFERENCES `STATUT` (`STATUT_ID`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Contraintes pour la table `LIEU_HAS_PHOTO`
--
ALTER TABLE `LIEU_HAS_PHOTO`
  ADD CONSTRAINT `llllllll` FOREIGN KEY (`PK_FK_LIEU_ID`) REFERENCES `LIEU` (`LIEU_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ppppppp` FOREIGN KEY (`PK_FK_PHOTO_ID`) REFERENCES `PHOTO` (`PHOTO_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `LIEU_HAS_TAG`
--
ALTER TABLE `LIEU_HAS_TAG`
  ADD CONSTRAINT `LIEU_HAS_TAG_ibfk_1` FOREIGN KEY (`PK_FK_LIEU_ID`) REFERENCES `LIEU` (`LIEU_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `LIEU_HAS_TAG_ibfk_2` FOREIGN KEY (`PK_FK_TAG_ID`) REFERENCES `TAG` (`TAG_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `PROJECT_HAS_LIEU`
--
ALTER TABLE `PROJECT_HAS_LIEU`
  ADD CONSTRAINT `FOREIGN KEY LIEU ID` FOREIGN KEY (`PK_FK_LIEU_ID`) REFERENCES `LIEU` (`LIEU_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `PRIMARY KEY LIEU ID` FOREIGN KEY (`PK_FK_LIEU_ID`) REFERENCES `LIEU` (`LIEU_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `TAG`
--
ALTER TABLE `TAG`
  ADD CONSTRAINT `categorie` FOREIGN KEY (`FK_CATEGORIE_ID`) REFERENCES `CATEGORIE` (`CATEGORIE_ID`) ON DELETE CASCADE ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
