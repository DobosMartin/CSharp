-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Sze 27. 08:29
-- Kiszolgáló verziója: 10.4.13-MariaDB
-- PHP verzió: 7.4.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `12c1`
--
CREATE DATABASE IF NOT EXISTS `12c1` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `12c1`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `konyvek`
--

CREATE TABLE `konyvek` (
  `konyvAz` int(11) NOT NULL,
  `szerzo` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `cim` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `kiado` varchar(50) COLLATE utf8mb4_hungarian_ci DEFAULT NULL,
  `megjelenes` date DEFAULT NULL,
  `oldalszam` int(11) DEFAULT NULL,
  `nettoAr` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `konyvek`
--

INSERT INTO `konyvek` (`konyvAz`, `szerzo`, `cim`, `kiado`, `megjelenes`, `oldalszam`, `nettoAr`) VALUES
(1, 'Gárdonyi Géza', 'Egri csillagok', 'Móra', '2012-07-09', 550, 2300),
(2, 'Fekete István', 'Tüskevár', 'Móra', '2016-10-06', 302, 3390),
(3, 'Fekete István', 'Vuk', 'Kossuth', '2020-05-17', NULL, 2200),
(4, 'Móricz Zsigmond', 'Légy ​jó mindhalálig', 'Európa', '2010-02-14', 284, 1800),
(5, 'Molnár Ferenc', 'A ​Pál utcai fiúk', 'Kossuth', '2014-02-19', 216, 2150),
(6, 'Gárdonyi Géza', 'A láthatatlan ember', 'Móra', '2014-03-25', 328, 3900);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `konyvek`
--
ALTER TABLE `konyvek`
  ADD PRIMARY KEY (`konyvAz`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `konyvek`
--
ALTER TABLE `konyvek`
  MODIFY `konyvAz` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
