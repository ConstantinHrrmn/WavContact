-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Hôte : waview.ch.mysql.service.one.com:3306
-- Généré le : jeu. 02 juin 2022 à 23:32
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
-- Base de données : `waview_chcontact`
--

-- --------------------------------------------------------

--
-- Structure de la table `ACTIVITE`
--

CREATE TABLE `ACTIVITE` (
  `ACTIVITE_ID` int(11) NOT NULL,
  `ACTIVITE_PERSONNE_FK` int(11) NOT NULL,
  `ACTIVITE_PROJET_FK` int(11) NOT NULL,
  `ACTIVITY_CONTENT` text NOT NULL,
  `ACTIVITE_MAJ` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `ACTIVITE`
--

INSERT INTO `ACTIVITE` (`ACTIVITE_ID`, `ACTIVITE_PERSONNE_FK`, `ACTIVITE_PROJET_FK`, `ACTIVITY_CONTENT`, `ACTIVITE_MAJ`) VALUES
(9, 1, 5, 'Document ajoute : Memoji_constantin.jpeg', '2022-05-16 12:29:05'),
(10, 1, 12, 'Document supprime : Memoji_constantin.jpeg', '2022-05-16 12:30:53'),
(33, 1, 13, 'Log : Ajout d\'une date', '2022-05-16 20:56:40'),
(34, 1, 13, 'Log : Modification de la date du tournage.', '2022-05-16 20:56:51'),
(36, 1, 12, 'Log : Ajout d\'une date', '2022-05-16 21:09:54'),
(37, 1, 12, 'Log : Suppression d\'une date', '2022-05-16 21:09:58'),
(38, 1, 12, 'Log : Modification du commentaire.', '2022-05-16 21:10:48'),
(40, 1, 12, 'Document ajoute : LUNA7821.jpg', '2022-05-16 21:42:38'),
(41, 1, 12, 'Log : Ajout d\'une date', '2022-05-16 21:43:06'),
(50, 1, 5, 'Document ajoute : guide_ref_bibliographie.pdf', '2022-05-17 13:47:39'),
(51, 1, 5, 'Document supprime : guide_ref_bibliographie.pdf', '2022-05-17 13:48:20'),
(52, 1, 5, 'Log : Ajout d\'une date', '2022-05-17 13:48:40'),
(53, 1, 5, 'Log : Modification du commentaire.', '2022-05-17 13:48:57'),
(57, 2, 5, 'Log : Ajout d\'une date', '2022-05-17 14:09:12'),
(58, 2, 5, 'Document ajoute : guide_ref_bibliographie.pdf', '2022-05-17 14:09:34'),
(73, 1, 0, 'Log : Modification des informations de : Bob Marle', '2022-05-22 20:14:41'),
(75, 1, 0, 'Log : Modification des informations de : Constantin Marco', '2022-05-22 21:20:31'),
(99, 75, 0, 'Log : Compte active !', '2022-05-31 10:35:43'),
(105, 1, 0, 'Log : Suppression du projet : Test', '2022-06-01 14:27:07'),
(107, 1, 0, 'Creation du projet : tretret', '2022-06-01 14:29:15'),
(110, 1, 0, 'Suppression du projet : tretret', '2022-06-01 14:29:58'),
(111, 1, 0, 'Modification des informations de : Martin Dubois', '2022-06-01 14:36:58'),
(113, 1, 0, 'Creation du projet : WAOW', '2022-06-01 14:37:09'),
(114, 0, 0, 'Client supprime : sdfsdfsd sdfsdfsd', '2022-06-01 14:50:33'),
(115, 1, 0, 'Modification des informations de : sdfsdfsd sdfsdfsd', '2022-06-01 14:50:36'),
(116, 1, 0, 'Creation du client : sdasdas adsadaasd', '2022-06-01 14:52:58'),
(117, 0, 0, 'Client supprime : sdasdas adsadaasd', '2022-06-01 14:53:10'),
(118, 1, 0, 'Creation du client : fdsfs sdfsdf', '2022-06-01 14:54:19'),
(120, 1, 0, 'Creation du projet : dsdfsdf', '2022-06-01 14:54:24'),
(121, 0, 0, 'Client supprime : fdsfs sdfsdf', '2022-06-01 14:54:30'),
(122, 1, 0, 'Creation du client : sfsdfsd fsdfs', '2022-06-01 14:56:09'),
(123, 0, 0, 'Client supprime : sfsdfsd fsdfs', '2022-06-01 14:56:15'),
(124, 0, 0, 'Client supprime : Constantin Herrmann', '2022-06-01 14:57:53'),
(125, 1, 0, 'Creation du client : Constantin Herrmann', '2022-06-01 15:02:49'),
(126, 1, 0, 'Creation du client : Coralie Chevalley', '2022-06-01 15:05:11'),
(128, 1, 0, 'Creation du projet : FPV HEG', '2022-06-01 15:09:30'),
(133, 1, 0, 'Creation du projet : Clip Karakoe', '2022-06-01 15:12:53'),
(134, 1, 27, 'Ajout d\'une date', '2022-06-01 15:13:22'),
(135, 1, 27, 'Ajout d\'une date', '2022-06-01 15:13:46'),
(136, 0, 27, 'Document ajoute :  Liste de tournage [13/07/2022 - 13/07/2022]', '2022-06-01 15:14:32'),
(138, 1, 27, 'Modification de la description.', '2022-06-01 15:25:17'),
(139, 1, 27, 'Modification du commentaire.', '2022-06-01 16:31:43'),
(140, 82, 27, 'Log : ajout lieu', '2022-06-01 16:52:13'),
(141, 82, 27, 'Log : ajout lieu', '2022-06-01 16:57:42'),
(142, 1, 27, 'Suppression d\'un lieu (Plage des Eaux-Vives)', '2022-06-01 17:40:45'),
(143, 82, 27, 'Document ajoute : Clip Kar.pdf', '2022-06-01 18:46:31'),
(144, 82, 27, 'Document supprime : Clip Kar.pdf', '2022-06-01 18:46:47'),
(145, 82, 27, 'Document supprime : Clip Kar.pdf', '2022-06-01 18:46:48'),
(146, 82, 27, 'Modification du commentaire.', '2022-06-01 18:47:26'),
(147, 1, 27, 'Modification du commentaire.', '2022-06-01 19:57:11'),
(149, 1, 0, 'Creation du projet : Luna', '2022-06-01 21:01:38'),
(150, 0, 0, 'Client supprime : Constantin Herrmann', '2022-06-01 21:01:54'),
(151, 1, 0, 'Log : ajout lieu', '2022-06-02 21:24:17'),
(152, 82, 27, 'Document supprime : Clip Karakoe_26_signed.pdf', '2022-06-02 22:09:10'),
(153, 82, 27, 'Document ajoute : flight-of-the-inner-bird by yehezkel-raz Artlist.wav', '2022-06-02 22:10:11'),
(154, 82, 27, 'Document supprime : Clip Karakoe_26_signed.pdf', '2022-06-02 22:15:15'),
(155, 82, 27, 'Signature du document Clip Karakoe_26.pdf', '2022-06-02 22:15:29'),
(156, 82, 27, 'Document supprime : Clip Karakoe_26_signed.pdf', '2022-06-02 22:16:15'),
(157, 82, 27, 'Signature du document :Clip Karakoe_26.pdf', '2022-06-02 22:16:28'),
(158, 82, 27, 'Document ajoute : chasing-dreams by hotham Artlist.wav', '2022-06-02 22:30:11'),
(159, 82, 27, 'Signature du document :Clip Karakoe_26.pdf', '2022-06-02 23:27:51'),
(160, 82, 27, 'Log : ajout lieu', '2022-06-03 00:35:26'),
(162, 1, 28, 'Ajout d\'une date', '2022-06-03 00:58:57'),
(163, 1, 28, 'Document ajoute : bibliographie_CompT.pptx', '2022-06-03 01:02:16'),
(164, 1, 27, 'Ajout d\'une date', '2022-06-03 01:13:42');

-- --------------------------------------------------------

--
-- Structure de la table `CATEGORIE`
--

CREATE TABLE `CATEGORIE` (
  `CATEGORIE_ID` int(11) NOT NULL,
  `CATEGORIE_NOM` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `CATEGORIE`
--

INSERT INTO `CATEGORIE` (`CATEGORIE_ID`, `CATEGORIE_NOM`) VALUES
(1, 'Camera'),
(2, 'Optique et accesoires'),
(3, 'Montiteur / Enregistreur vidéo'),
(4, 'Stabilisation'),
(5, 'Éclairage'),
(6, 'Batteries'),
(7, 'SmallRig'),
(8, 'Câbles et connectiques'),
(9, 'Rig et machinerie'),
(10, 'Audio'),
(11, 'Autre');

-- --------------------------------------------------------

--
-- Structure de la table `CHAT_GROUP`
--

CREATE TABLE `CHAT_GROUP` (
  `GROUP_ID` int(11) NOT NULL,
  `CLIENT_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `CHAT_GROUP`
--

INSERT INTO `CHAT_GROUP` (`GROUP_ID`, `CLIENT_ID`) VALUES
(1, 2),
(8, 59),
(18, 75),
(25, 82);

-- --------------------------------------------------------

--
-- Structure de la table `CHAT_MEMBER_OF`
--

CREATE TABLE `CHAT_MEMBER_OF` (
  `PERSONNE_ID` int(11) NOT NULL,
  `GROUP_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `CHAT_MEMBER_OF`
--

INSERT INTO `CHAT_MEMBER_OF` (`PERSONNE_ID`, `GROUP_ID`) VALUES
(1, 1),
(2, 1),
(59, 8),
(1, 8),
(75, 18),
(1, 18),
(62, 18),
(82, 25),
(1, 25),
(62, 25);

-- --------------------------------------------------------

--
-- Structure de la table `CHAT_MESSAGE`
--

CREATE TABLE `CHAT_MESSAGE` (
  `CHAT_MESSAGE_ID` int(11) NOT NULL,
  `MESSAGE_SENDER_ID` int(11) NOT NULL COMMENT 'Id d''une personne',
  `MESSAGE_GROUP_ID` int(11) NOT NULL,
  `MESSAGE_CONTENT` text NOT NULL,
  `MESSAGE_TIME` datetime NOT NULL,
  `MESSAGE_HIDDEN` tinyint(4) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `CHAT_MESSAGE`
--

INSERT INTO `CHAT_MESSAGE` (`CHAT_MESSAGE_ID`, `MESSAGE_SENDER_ID`, `MESSAGE_GROUP_ID`, `MESSAGE_CONTENT`, `MESSAGE_TIME`, `MESSAGE_HIDDEN`) VALUES
(1, 1, 25, 'j\\\'ai faim', '2022-06-01 18:42:33', 0),
(2, 1, 25, 'hello', '2022-06-01 18:42:39', 0),
(3, 1, 25, '<elllehhha<', '2022-06-01 18:42:47', 0),
(4, 1, 25, '\\j\\\\\'ai faim', '2022-06-01 18:43:02', 0),
(5, 82, 25, 'helloooooooooo comment vas-tu ?', '2022-06-01 18:43:42', 0),
(6, 82, 25, 'j\\\'ai aussi faimmmm', '2022-06-01 18:43:49', 0),
(7, 82, 25, 'on mange quand Sabrina ?', '2022-06-01 18:43:57', 0),
(8, 1, 25, 'QUOI ENCORE ?', '2022-06-01 18:44:15', 0),
(9, 82, 25, 'rien', '2022-06-02 22:09:36', 0),
(10, 1, 25, 'OKOK', '2022-06-02 23:17:50', 0),
(11, 82, 25, 'Cool', '2022-06-02 23:28:35', 0),
(14, 82, 25, 'Je fait des tests', '2022-06-03 01:27:24', 0),
(15, 1, 25, 'Tu voit ce message ?', '2022-06-03 01:27:55', 0),
(16, 82, 25, '*vois', '2022-06-03 01:28:04', 0),
(17, 1, 25, '[HIDDEN] Ce message tu ne le voit pas', '2022-06-03 01:28:13', 1),
(18, 1, 25, 'Et lui ?', '2022-06-03 01:28:19', 0),
(19, 82, 25, 'oui', '2022-06-03 01:28:27', 0),
(20, 82, 25, 'qu\\\'est ce que tu fais demain ?', '2022-06-03 01:28:44', 0),
(21, 82, 25, 'ah', '2022-06-03 01:28:49', 0),
(22, 1, 25, 'Salut', '2022-06-03 01:29:03', 0),
(23, 1, 25, '[HIDDEN] Cache', '2022-06-03 01:29:26', 1);

-- --------------------------------------------------------

--
-- Structure de la table `CHAT_SENDING_MESSAGE`
--

CREATE TABLE `CHAT_SENDING_MESSAGE` (
  `PERSONNE_ID` int(11) NOT NULL,
  `MESSAGE_ID` int(11) NOT NULL,
  `GROUP_ID` int(11) NOT NULL,
  `OPENED` tinyint(4) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `CHAT_SENDING_MESSAGE`
--

INSERT INTO `CHAT_SENDING_MESSAGE` (`PERSONNE_ID`, `MESSAGE_ID`, `GROUP_ID`, `OPENED`) VALUES
(62, 1, 25, 0),
(62, 2, 25, 0),
(62, 3, 25, 0),
(62, 4, 25, 0),
(62, 5, 25, 0),
(62, 6, 25, 0),
(62, 7, 25, 0),
(62, 8, 25, 0),
(62, 9, 25, 0),
(62, 10, 25, 0),
(62, 11, 25, 0),
(62, 14, 25, 0),
(62, 15, 25, 0),
(62, 16, 25, 0),
(62, 17, 25, 0),
(62, 18, 25, 0),
(62, 19, 25, 0),
(62, 20, 25, 0),
(62, 21, 25, 0),
(82, 22, 25, 0),
(62, 22, 25, 0),
(62, 23, 25, 0);

-- --------------------------------------------------------

--
-- Structure de la table `MATERIEL`
--

CREATE TABLE `MATERIEL` (
  `MATERIEL_ID` int(11) NOT NULL,
  `FK_CATEGORIE_ID` int(11) NOT NULL,
  `MATERIEL_NOM` varchar(128) NOT NULL,
  `MATERIEL_DESCRIPTION` varchar(255) DEFAULT NULL,
  `MATERIEL_PRIX` decimal(10,2) DEFAULT NULL,
  `MATERIEL_QUANTITE` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `MATERIEL`
--

INSERT INTO `MATERIEL` (`MATERIEL_ID`, `FK_CATEGORIE_ID`, `MATERIEL_NOM`, `MATERIEL_DESCRIPTION`, `MATERIEL_PRIX`, `MATERIEL_QUANTITE`) VALUES
(1, 1, 'Ursa', 'Ursa Mini Pro 4.6K', '4500.00', 1),
(2, 1, 'Pocket', 'Pocket Cinema Camera 4K', '1200.00', 1),
(3, 1, 'Canon', 'Canon eos R', '3200.00', 1),
(4, 1, 'Hero 6', 'Go pro Hero 6', '450.00', 1),
(5, 1, 'Ursa poignée', 'Poignée Ursa Mini Pro', '0.00', 1),
(6, 2, 'Rokinon 24mm', 'SAMYANG 24mm T1.5 Cine', '0.00', 1),
(7, 2, 'Rokinon 35mm', 'SAMYANG 35mm T1.5 Cine', '0.00', 1),
(8, 2, 'Rokinon 50mm', 'SAMYANG 50mm T1.5 Cine', '0.00', 1),
(9, 2, 'Rokinon 80mm', 'SAMYANG 80mm T1.5 Cine', '0.00', 1),
(10, 2, 'Sigma 18-35', 'Sigma Art 18-35mm F1.8', '0.00', 1),
(11, 2, 'Lumix 14-140', 'Lumix G 14-140mm f/3.5-5-6', '0.00', 1),
(12, 2, 'Canon 24-105mm', 'Canon RF 24-105mm f/4L', '0.00', 1),
(14, 2, 'Filtre ND', 'Fader MC ND', '0.00', 1),
(15, 3, 'Odyssey', 'Odyssey 7q+', '0.00', 1),
(16, 3, 'Feelworld', 'Feelworld F7S', '0.00', 1),
(17, 4, 'Movi', 'Movi Pro', '0.00', 1),
(18, 4, 'Glidecam Devin', 'Glidecam Devin Series', '0.00', 1),
(19, 4, 'Veste glidecam', 'Flycam Galaxy', '0.00', 1),
(20, 5, 'Aputure', '120D mk2', '0.00', 1),
(21, 5, 'Led Smallrig', 'Pix M160', '0.00', 1),
(22, 5, 'Led Tristar', 'Alp 4', '0.00', 1),
(23, 5, 'Panneau diffuseur', 'Panneau 4 en 1', '0.00', 1),
(24, 6, 'V-Lock', 'Patona 190w', '0.00', 3),
(25, 6, 'Np', 'NP-F950', '0.00', 6),
(26, 6, 'Lpe6', 'LPE6', '0.00', 6),
(27, 6, 'Movi Battery', 'MOVI Battery', '0.00', 4),
(28, 6, 'V-Lock Plate', 'V-mount Rod adapter', '0.00', 2),
(29, 6, 'Np Plate', 'NP-F950 Plate', '0.00', 1),
(30, 7, 'Cage Pocket', 'Pocket 4k cage', '0.00', 1),
(31, 7, 'Bras Maj grand', 'Grand Bras Magique', '0.00', 2),
(32, 7, 'Bras Maj Petit', 'Petit bras magique', '0.00', 2),
(33, 7, 'Bras Maj Mini', 'Mini bras magique', '0.00', 2),
(34, 7, 'Clamp mini', 'Mini Clamp', '0.00', 4),
(35, 7, 'Tête griffe', 'Tête articulée griffe', '0.00', 2),
(36, 7, 'Rods', 'Rods accessoires', '0.00', 1),
(37, 7, 'Tête moniteur', 'Tête moniteur', '0.00', 1),
(38, 7, 'Top Handle', 'Poignées supérieures', '0.00', 2),
(39, 7, 'Support Rod', 'Support rod', '0.00', 2),
(40, 7, 'V-mount mini Plate', 'Mini V Mount Battery Plate 2987', '0.00', 1),
(41, 7, 'Cheese plate', 'Mounting Cheese Plate 1598', '0.00', 1),
(42, 7, 'SSD mount', 'T5 Mount', '0.00', 1),
(43, 8, 'SDI 130', 'SDI 130', '0.00', 2),
(44, 8, 'SDI 30', 'SDI 30', '0.00', 3),
(45, 8, 'HDMI 70', 'HDMI 70', '0.00', 2),
(46, 8, 'HDMI movi', 'HDMI THIN', '0.00', 1),
(47, 8, 'HDMI adapt coudé', 'HDMI adaptateur coudé', '0.00', 1),
(48, 8, 'USCBC Samsung', 'USCBC Samsung', '0.00', 2),
(49, 8, 'USCBC-A Samsung', 'USCBC Samsung', '0.00', 2),
(50, 8, 'DTAP Odyssey', 'DTAP Odyssey', '0.00', 1),
(51, 8, 'DTAP Ursa', 'DTAP Ursa Mini Pro', '0.00', 1),
(52, 8, 'DTAP Pocket', 'DTAP Pocket 4k', '0.00', 2),
(53, 8, 'DTAP-DC', 'DTAP DC', '0.00', 1),
(54, 8, 'DTAP-MULTIDTAP', 'DTAP MULTIDTAP', '0.00', 1),
(55, 8, 'DC Pocket', 'DC Pocket 4K', '0.00', 1),
(56, 8, 'DC-LPE6', 'DC LPE6', '0.00', 1),
(57, 9, 'C-Stand', 'Neewer C-Stand', '0.00', 2),
(58, 9, 'Bras C-stand', 'Neewer bras de déport', '0.00', 2),
(59, 9, 'Rotule', 'Rotule', '0.00', 4),
(60, 9, 'Sac Sable', 'Sac Sable', '0.00', 4),
(61, 9, 'Sping Clamp', 'Spring Clamp Manfrotto 175', '0.00', 1),
(62, 9, 'Mini pied alu', 'Mini pied alu', '0.00', 2),
(63, 9, 'Trépied', 'Trépied amazon', '0.00', 1),
(64, 9, 'Dolly', 'Dolly trépied', '0.00', 1),
(92, 11, 'Tesla Model S', 'Model 3 Performance', '67700.00', 1),
(94, 1, 'Mavic Pro 2', 'Tout le kit du mavic', '1980.00', 1),
(106, 11, 'Toyota Yaris', 'LA Yaris', '50000.00', 1);

-- --------------------------------------------------------

--
-- Structure de la table `PERSONNE`
--

CREATE TABLE `PERSONNE` (
  `PERSONNE_ID` int(11) NOT NULL,
  `PERSONNE_NOM` varchar(60) NOT NULL,
  `PERSONNE_PRENOM` varchar(50) NOT NULL,
  `PERSONNE_MAIL` varchar(255) NOT NULL,
  `PERSONNE_MDP` text DEFAULT NULL,
  `PERSONNE_TEL` varchar(14) DEFAULT NULL,
  `FK_ROLE_ID` int(11) DEFAULT 2,
  `PERSONNE_ACTIVE` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `PERSONNE`
--

INSERT INTO `PERSONNE` (`PERSONNE_ID`, `PERSONNE_NOM`, `PERSONNE_PRENOM`, `PERSONNE_MAIL`, `PERSONNE_MDP`, `PERSONNE_TEL`, `FK_ROLE_ID`, `PERSONNE_ACTIVE`) VALUES
(0, 'WAVIEW', 'WAVIEW', 'info@waview.ch', NULL, NULL, 4, 1),
(1, 'Herrmann', 'Constantin', 'constantin@waview.ch', 'd4a3ea96b766b9616eff33cc98808fae8edc29f9f6a6f8ef56e1c5f92143ae2276ff4c41158835c4d4b3cdab0b8f3fd54c81a4513e63d7a9b1a008f9d391de2b', '0798828925', 1, 1),
(2, 'Joye', 'Sabrina', 'joye.sabrina@gmail.com', '28b334271248084d91b10d632b9f2619b0b5df62e861f7d704299cb19db73a851bfcdf1bb365438ac7c42a5a06fa1001fcace524e60985dd7ee20d4bd2c6de6d', '0786686072', 2, 1),
(59, 'Roch', 'David', 'roch.david@hes.ch', '3a0dc6ec6e6bdd6aa95da0e4dd0855e340200b214de169cdb1a794500837ee2600b44e7f3ab3e1d3387eb15109d23d976a4743d455910e29ed198900984bcae6', '0791234567', 2, 1),
(62, 'Viatte', 'Loic', 'loic@waview.ch', '290e02a61f7b0b632768004132b459de2af17640fcdb1de895b144422d5f018e45d410c36ae515c8e5be9988150f753930249f0cd6ab1cc207704538e748ce86', '0791234567', 1, 1),
(75, 'Mourin', 'Angela', 'angela.mourin@etu.hesge.ch', '10c6113edcb2870b12ab188a6e2cdcbdc23dcaccf88784ee6912b37e4b5f572cf7b86ada9aa571e58af4399c8a4c06c3380a8e054c98e938e66d0be774c8392a', '0785437641', 2, 1),
(82, 'Chevalley', 'Coralie', 'coralie.chevalley@gmail.com', '882f03645c4c93ce50a9a0fc9617a89cf4a4d212ce94496721ee935ac2b20a94efb98f440d26837d844203434a7a321002185955b105ef34274e6320bc48f61c', '0786598755', 2, 1);

-- --------------------------------------------------------

--
-- Structure de la table `PROJET`
--

CREATE TABLE `PROJET` (
  `PROJET_ID` int(11) NOT NULL,
  `FK_PERSONNE_ID` int(11) NOT NULL,
  `PROJET_NOM` varchar(60) NOT NULL,
  `PROJET_DESCRIPTION` varchar(255) NOT NULL,
  `PROJET_VALIDER` int(11) NOT NULL DEFAULT 0,
  `PROJET_COMMENTAIRE` text NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `PROJET`
--

INSERT INTO `PROJET` (`PROJET_ID`, `FK_PERSONNE_ID`, `PROJET_NOM`, `PROJET_DESCRIPTION`, `PROJET_VALIDER`, `PROJET_COMMENTAIRE`) VALUES
(0, 1, 'ADMIN', 'GEstion administration', 0, ''),
(27, 82, 'Clip Karakoe', 'Presenter le nouveau projet de KARAOKE a Geneve', 0, 'Il faut voir comment faire de nuit.'),
(28, 2, 'Luna', 'Faire une video dynamique au sujet de Luna fin de l\'inscrire dans des competitions.', 0, '');

-- --------------------------------------------------------

--
-- Structure de la table `RESERVATION`
--

CREATE TABLE `RESERVATION` (
  `RESERVATION_ID` int(11) NOT NULL,
  `TOURNAGE_FK` int(11) NOT NULL,
  `PROJET_FK` int(11) NOT NULL,
  `MATERIEL_ID` int(11) NOT NULL,
  `RESERVATION_QUANTITE` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `RESERVATION`
--

INSERT INTO `RESERVATION` (`RESERVATION_ID`, `TOURNAGE_FK`, `PROJET_FK`, `MATERIEL_ID`, `RESERVATION_QUANTITE`) VALUES
(29, 26, 27, 1, 1),
(30, 26, 27, 2, 1),
(31, 26, 27, 6, 1),
(32, 26, 27, 7, 1),
(33, 26, 27, 8, 1),
(34, 26, 27, 22, 1),
(35, 26, 27, 30, 1);

-- --------------------------------------------------------

--
-- Structure de la table `ROLE`
--

CREATE TABLE `ROLE` (
  `ROLE_ID` int(11) NOT NULL,
  `ROLE_NAME` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `ROLE`
--

INSERT INTO `ROLE` (`ROLE_ID`, `ROLE_NAME`) VALUES
(1, 'Collaborateur'),
(2, 'Client'),
(3, 'Photographe'),
(4, 'Administrateur'),
(5, 'Unknown');

-- --------------------------------------------------------

--
-- Structure de la table `TOURNAGE`
--

CREATE TABLE `TOURNAGE` (
  `TOURNAGE_ID` int(11) NOT NULL,
  `TOURNAGE_PROJET_ID` int(11) NOT NULL,
  `TOURNAGE_DEBUT` datetime NOT NULL,
  `TOURNAGE_FIN` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `TOURNAGE`
--

INSERT INTO `TOURNAGE` (`TOURNAGE_ID`, `TOURNAGE_PROJET_ID`, `TOURNAGE_DEBUT`, `TOURNAGE_FIN`) VALUES
(26, 27, '2022-07-13 10:00:18', '2022-07-13 19:00:58'),
(27, 27, '2022-07-14 10:00:18', '2022-07-14 13:30:22'),
(28, 28, '2022-05-16 19:47:18', '2022-06-03 00:58:50'),
(29, 27, '2022-06-03 01:23:34', '2022-06-03 03:13:34');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `ACTIVITE`
--
ALTER TABLE `ACTIVITE`
  ADD PRIMARY KEY (`ACTIVITE_ID`),
  ADD KEY `PP` (`ACTIVITE_PERSONNE_FK`),
  ADD KEY `PROJ` (`ACTIVITE_PROJET_FK`);

--
-- Index pour la table `CATEGORIE`
--
ALTER TABLE `CATEGORIE`
  ADD PRIMARY KEY (`CATEGORIE_ID`);

--
-- Index pour la table `CHAT_GROUP`
--
ALTER TABLE `CHAT_GROUP`
  ADD PRIMARY KEY (`GROUP_ID`),
  ADD KEY `CG` (`CLIENT_ID`);

--
-- Index pour la table `CHAT_MEMBER_OF`
--
ALTER TABLE `CHAT_MEMBER_OF`
  ADD KEY `MEMBER_OF_PERSONNE` (`PERSONNE_ID`),
  ADD KEY `MEMBER_OF_GROUP` (`GROUP_ID`);

--
-- Index pour la table `CHAT_MESSAGE`
--
ALTER TABLE `CHAT_MESSAGE`
  ADD PRIMARY KEY (`CHAT_MESSAGE_ID`),
  ADD KEY `PMG` (`MESSAGE_SENDER_ID`),
  ADD KEY `CMG` (`MESSAGE_GROUP_ID`);

--
-- Index pour la table `CHAT_SENDING_MESSAGE`
--
ALTER TABLE `CHAT_SENDING_MESSAGE`
  ADD KEY `GS` (`GROUP_ID`),
  ADD KEY `MS` (`MESSAGE_ID`),
  ADD KEY `PS` (`PERSONNE_ID`);

--
-- Index pour la table `MATERIEL`
--
ALTER TABLE `MATERIEL`
  ADD PRIMARY KEY (`MATERIEL_ID`),
  ADD KEY `FK_CATEGORIE_ID` (`FK_CATEGORIE_ID`);

--
-- Index pour la table `PERSONNE`
--
ALTER TABLE `PERSONNE`
  ADD PRIMARY KEY (`PERSONNE_ID`);

--
-- Index pour la table `PROJET`
--
ALTER TABLE `PROJET`
  ADD PRIMARY KEY (`PROJET_ID`),
  ADD KEY `client` (`FK_PERSONNE_ID`);

--
-- Index pour la table `RESERVATION`
--
ALTER TABLE `RESERVATION`
  ADD PRIMARY KEY (`RESERVATION_ID`),
  ADD KEY `pppp` (`PROJET_FK`),
  ADD KEY `tttt` (`TOURNAGE_FK`),
  ADD KEY `mmmm` (`MATERIEL_ID`);

--
-- Index pour la table `ROLE`
--
ALTER TABLE `ROLE`
  ADD PRIMARY KEY (`ROLE_ID`);

--
-- Index pour la table `TOURNAGE`
--
ALTER TABLE `TOURNAGE`
  ADD PRIMARY KEY (`TOURNAGE_ID`),
  ADD KEY `ppp` (`TOURNAGE_PROJET_ID`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `ACTIVITE`
--
ALTER TABLE `ACTIVITE`
  MODIFY `ACTIVITE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=165;

--
-- AUTO_INCREMENT pour la table `CATEGORIE`
--
ALTER TABLE `CATEGORIE`
  MODIFY `CATEGORIE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT pour la table `CHAT_GROUP`
--
ALTER TABLE `CHAT_GROUP`
  MODIFY `GROUP_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT pour la table `CHAT_MESSAGE`
--
ALTER TABLE `CHAT_MESSAGE`
  MODIFY `CHAT_MESSAGE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT pour la table `MATERIEL`
--
ALTER TABLE `MATERIEL`
  MODIFY `MATERIEL_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=108;

--
-- AUTO_INCREMENT pour la table `PERSONNE`
--
ALTER TABLE `PERSONNE`
  MODIFY `PERSONNE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=84;

--
-- AUTO_INCREMENT pour la table `PROJET`
--
ALTER TABLE `PROJET`
  MODIFY `PROJET_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT pour la table `RESERVATION`
--
ALTER TABLE `RESERVATION`
  MODIFY `RESERVATION_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT pour la table `ROLE`
--
ALTER TABLE `ROLE`
  MODIFY `ROLE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `TOURNAGE`
--
ALTER TABLE `TOURNAGE`
  MODIFY `TOURNAGE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `ACTIVITE`
--
ALTER TABLE `ACTIVITE`
  ADD CONSTRAINT `PP` FOREIGN KEY (`ACTIVITE_PERSONNE_FK`) REFERENCES `PERSONNE` (`PERSONNE_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `PROJ` FOREIGN KEY (`ACTIVITE_PROJET_FK`) REFERENCES `PROJET` (`PROJET_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `CHAT_GROUP`
--
ALTER TABLE `CHAT_GROUP`
  ADD CONSTRAINT `CG` FOREIGN KEY (`CLIENT_ID`) REFERENCES `PERSONNE` (`PERSONNE_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `CHAT_MEMBER_OF`
--
ALTER TABLE `CHAT_MEMBER_OF`
  ADD CONSTRAINT `MEMBER_OF_GROUP` FOREIGN KEY (`GROUP_ID`) REFERENCES `CHAT_GROUP` (`GROUP_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `MEMBER_OF_PERSONNE` FOREIGN KEY (`PERSONNE_ID`) REFERENCES `PERSONNE` (`PERSONNE_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `CHAT_MESSAGE`
--
ALTER TABLE `CHAT_MESSAGE`
  ADD CONSTRAINT `CMG` FOREIGN KEY (`MESSAGE_GROUP_ID`) REFERENCES `CHAT_GROUP` (`GROUP_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `PMG` FOREIGN KEY (`MESSAGE_SENDER_ID`) REFERENCES `PERSONNE` (`PERSONNE_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `CHAT_SENDING_MESSAGE`
--
ALTER TABLE `CHAT_SENDING_MESSAGE`
  ADD CONSTRAINT `GS` FOREIGN KEY (`GROUP_ID`) REFERENCES `CHAT_GROUP` (`GROUP_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `MS` FOREIGN KEY (`MESSAGE_ID`) REFERENCES `CHAT_MESSAGE` (`CHAT_MESSAGE_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `PS` FOREIGN KEY (`PERSONNE_ID`) REFERENCES `PERSONNE` (`PERSONNE_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `MATERIEL`
--
ALTER TABLE `MATERIEL`
  ADD CONSTRAINT `MATERIEL_ibfk_1` FOREIGN KEY (`FK_CATEGORIE_ID`) REFERENCES `CATEGORIE` (`CATEGORIE_ID`);

--
-- Contraintes pour la table `PROJET`
--
ALTER TABLE `PROJET`
  ADD CONSTRAINT `client` FOREIGN KEY (`FK_PERSONNE_ID`) REFERENCES `PERSONNE` (`PERSONNE_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `RESERVATION`
--
ALTER TABLE `RESERVATION`
  ADD CONSTRAINT `mmmm` FOREIGN KEY (`MATERIEL_ID`) REFERENCES `MATERIEL` (`MATERIEL_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pppp` FOREIGN KEY (`PROJET_FK`) REFERENCES `PROJET` (`PROJET_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tttt` FOREIGN KEY (`TOURNAGE_FK`) REFERENCES `TOURNAGE` (`TOURNAGE_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `TOURNAGE`
--
ALTER TABLE `TOURNAGE`
  ADD CONSTRAINT `ppp` FOREIGN KEY (`TOURNAGE_PROJET_ID`) REFERENCES `PROJET` (`PROJET_ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
