-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Czas generowania: 28 Sty 2017, 21:13
-- Wersja serwera: 10.1.19-MariaDB
-- Wersja PHP: 7.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `bd`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `hotel`
--

CREATE TABLE `hotel` (
  `idHotel` int(11) NOT NULL,
  `nazwa` varchar(20) NOT NULL,
  `miasto` varchar(20) NOT NULL,
  `standard` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `hotel`
--

INSERT INTO `hotel` (`idHotel`, `nazwa`, `miasto`, `standard`) VALUES
(1, 'Podewils', 'Gdansk', 5),
(2, 'InterContinantal', 'Warszawa', 5),
(3, 'Bristol', 'Warszawa', 5),
(4, 'Gródek', 'Kraków', 5),
(5, 'Sheraton', 'Kraków', 5);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klient`
--

CREATE TABLE `klient` (
  `idKlient` int(6) NOT NULL,
  `imie` varchar(20) NOT NULL,
  `nazwisko` varchar(20) NOT NULL,
  `telefon` int(9) NOT NULL,
  `email` varchar(45) NOT NULL,
  `nr_dowodu` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `klient`
--

INSERT INTO `klient` (`idKlient`, `imie`, `nazwisko`, `telefon`, `email`, `nr_dowodu`) VALUES
(15, 'asd', 'asd', 123123123, '1231asd', '123123123');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pokoj`
--

CREATE TABLE `pokoj` (
  `idPokoj` int(3) NOT NULL,
  `idHotel` int(11) NOT NULL,
  `idPokoj_rodzaj` int(2) NOT NULL,
  `cena` float NOT NULL,
  `lokalizacja` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `pokoj`
--

INSERT INTO `pokoj` (`idPokoj`, `idHotel`, `idPokoj_rodzaj`, `cena`, `lokalizacja`) VALUES
(10, 0, 1, 190, 'parter'),
(11, 0, 2, 239, 'parter'),
(12, 0, 3, 240, 'parter'),
(20, 1, 1, 190, 'parter'),
(21, 1, 2, 239, 'parter'),
(22, 1, 3, 240, 'parter'),
(30, 2, 1, 190, 'parter'),
(31, 2, 2, 239, 'parter'),
(32, 2, 3, 240, 'parter'),
(40, 3, 1, 190, 'parter'),
(41, 3, 2, 239, 'parter'),
(42, 3, 3, 240, 'parter'),
(50, 4, 1, 190, 'parter'),
(51, 4, 2, 239, 'parter'),
(52, 4, 3, 240, 'parter'),
(113, 0, 1, 239, '1 pietro'),
(114, 0, 2, 239, '1 pietro'),
(115, 0, 3, 240, '1 pietro'),
(123, 1, 1, 239, '1 pietro'),
(124, 1, 2, 239, '1 pietro'),
(125, 1, 3, 240, '1 pietro'),
(133, 2, 1, 239, '1 pietro'),
(134, 2, 2, 239, '1 pietro'),
(135, 2, 3, 240, '1 pietro'),
(143, 3, 1, 239, '1 pietro'),
(144, 3, 2, 239, '1 pietro'),
(145, 3, 3, 240, '1 pietro'),
(153, 4, 1, 239, '1 pietro'),
(154, 4, 2, 239, '1 pietro'),
(155, 4, 3, 240, '1 pietro'),
(216, 0, 1, 190, '2 pietro'),
(217, 0, 2, 239, '2 pietro'),
(218, 0, 3, 240, '2 pietro'),
(226, 1, 1, 190, '2 pietro'),
(227, 1, 2, 239, '2 pietro'),
(228, 1, 3, 240, '2 pietro'),
(236, 2, 1, 190, '2 pietro'),
(237, 2, 2, 239, '2 pietro'),
(238, 2, 3, 240, '2 pietro'),
(246, 3, 1, 190, '2 pietro'),
(247, 3, 2, 239, '2 pietro'),
(248, 3, 3, 240, '2 pietro'),
(256, 4, 1, 190, '2 pietro'),
(257, 4, 2, 239, '2 pietro'),
(258, 4, 3, 240, '2 pietro'),
(303, 0, 4, 330, '3 pietro'),
(313, 1, 4, 330, '3 pietro'),
(323, 2, 4, 330, '3 pietro'),
(333, 3, 4, 330, '3 pietro'),
(343, 4, 4, 330, '3 pietro');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pokoj_rodzaj`
--

CREATE TABLE `pokoj_rodzaj` (
  `idPokoj_rodzaj` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `pokoj_rodzaj`
--

INSERT INTO `pokoj_rodzaj` (`idPokoj_rodzaj`) VALUES
(1),
(2),
(3),
(4);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `posilek`
--

CREATE TABLE `posilek` (
  `idPosilek` int(11) NOT NULL,
  `idProdukt` int(2) NOT NULL,
  `Typ` enum('maly','sredni','duzy') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `posilek`
--

INSERT INTO `posilek` (`idPosilek`, `idProdukt`, `Typ`) VALUES
(0, 0, 'maly'),
(1, 0, 'sredni'),
(2, 0, 'duzy'),
(3, 1, 'maly'),
(4, 1, 'sredni'),
(5, 1, 'duzy'),
(6, 2, 'maly'),
(7, 2, 'sredni'),
(8, 2, 'duzy'),
(9, 3, 'maly'),
(10, 3, 'sredni'),
(11, 3, 'duzy'),
(12, 4, 'maly'),
(13, 4, 'sredni'),
(14, 4, 'duzy'),
(15, 5, 'maly'),
(16, 5, 'sredni'),
(17, 5, 'duzy'),
(18, 6, 'maly'),
(19, 6, 'sredni'),
(20, 6, 'duzy'),
(21, 7, 'maly'),
(22, 7, 'sredni'),
(23, 7, 'duzy'),
(24, 8, 'maly'),
(25, 8, 'sredni'),
(26, 8, 'duzy'),
(27, 9, 'maly'),
(28, 9, 'sredni'),
(29, 9, 'duzy');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `produkt`
--

CREATE TABLE `produkt` (
  `idProdukt` int(2) NOT NULL,
  `nazwa` varchar(50) NOT NULL,
  `cena` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `produkt`
--

INSERT INTO `produkt` (`idProdukt`, `nazwa`, `cena`) VALUES
(0, 'schabowy z ziemniakami', 18),
(1, 'mielony z ziemniakami', 17),
(2, 'nalesniki z serem', 10),
(3, 'nalesniki z nutella', 11),
(4, 'filet kurczaka z ryzem', 17),
(5, 'filet kurczaka w panierce z frytkami', 17),
(6, 'Zupa pomidorowa z makaronem', 9.99),
(7, 'Filet z lososia ze szpinakiem', 19),
(8, 'Makaron linguine z sosem pomidorowym', 18),
(9, 'Rosól z makaronem', 9);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `rezerwacja`
--

CREATE TABLE `rezerwacja` (
  `idRezerwacja` int(6) NOT NULL,
  `idUslugi` int(3) NOT NULL,
  `idPokoj` int(3) NOT NULL,
  `idPosilek` int(11) NOT NULL,
  `idKlient` int(6) NOT NULL,
  `idHotel` int(11) NOT NULL,
  `data_przyjazdu` date NOT NULL,
  `data_odjazdu` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `rezerwacja`
--

INSERT INTO `rezerwacja` (`idRezerwacja`, `idUslugi`, `idPokoj`, `idPosilek`, `idKlient`, `idHotel`, `data_przyjazdu`, `data_odjazdu`) VALUES
(3, 0, 20, 29, 11, 1, '2016-01-01', '2016-01-10'),
(9, 0, 123, 29, 15, 1, '2016-01-01', '2016-01-02');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `uslugi`
--

CREATE TABLE `uslugi` (
  `idUslugi` int(3) NOT NULL,
  `idUslugi_rodzaj` int(2) NOT NULL,
  `cena` float NOT NULL,
  `opis` varchar(20) NOT NULL,
  `nazwa` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `uslugi`
--

INSERT INTO `uslugi` (`idUslugi`, `idUslugi_rodzaj`, `cena`, `opis`, `nazwa`) VALUES
(0, 0, 15, 'sniadanie', 'sniadanie'),
(1, 1, 20, 'Telewizja w pokoju', 'Telewizja w pokoju'),
(2, 2, 50, 'butelka wina', 'butelka wina'),
(3, 3, 25, 'wifi dla pokoju', 'wifi dla pokoju'),
(4, 4, 50, 'kwiaty i czekoladki', 'kwiaty i czekoladki');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `uslugi_rodzaj`
--

CREATE TABLE `uslugi_rodzaj` (
  `idUslugi_rodzaj` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `uslugi_rodzaj`
--

INSERT INTO `uslugi_rodzaj` (`idUslugi_rodzaj`) VALUES
(0),
(1),
(2),
(3),
(4);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indexes for table `hotel`
--
ALTER TABLE `hotel`
  ADD PRIMARY KEY (`idHotel`) USING BTREE;

--
-- Indexes for table `klient`
--
ALTER TABLE `klient`
  ADD PRIMARY KEY (`idKlient`) USING BTREE,
  ADD UNIQUE KEY `nr_dowodu` (`nr_dowodu`);

--
-- Indexes for table `pokoj`
--
ALTER TABLE `pokoj`
  ADD PRIMARY KEY (`idPokoj`);

--
-- Indexes for table `pokoj_rodzaj`
--
ALTER TABLE `pokoj_rodzaj`
  ADD PRIMARY KEY (`idPokoj_rodzaj`);

--
-- Indexes for table `posilek`
--
ALTER TABLE `posilek`
  ADD PRIMARY KEY (`idPosilek`);

--
-- Indexes for table `produkt`
--
ALTER TABLE `produkt`
  ADD PRIMARY KEY (`idProdukt`);

--
-- Indexes for table `rezerwacja`
--
ALTER TABLE `rezerwacja`
  ADD PRIMARY KEY (`idRezerwacja`),
  ADD UNIQUE KEY `idPokoj` (`idPokoj`);

--
-- Indexes for table `uslugi`
--
ALTER TABLE `uslugi`
  ADD PRIMARY KEY (`idUslugi`) USING BTREE;

--
-- Indexes for table `uslugi_rodzaj`
--
ALTER TABLE `uslugi_rodzaj`
  ADD PRIMARY KEY (`idUslugi_rodzaj`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `hotel`
--
ALTER TABLE `hotel`
  MODIFY `idHotel` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT dla tabeli `klient`
--
ALTER TABLE `klient`
  MODIFY `idKlient` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT dla tabeli `pokoj`
--
ALTER TABLE `pokoj`
  MODIFY `idPokoj` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=344;
--
-- AUTO_INCREMENT dla tabeli `rezerwacja`
--
ALTER TABLE `rezerwacja`
  MODIFY `idRezerwacja` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
