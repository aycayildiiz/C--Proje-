-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 24 May 2024, 20:19:59
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `proje01`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_kullanici`
--

CREATE TABLE `tbl_kullanici` (
  `ad` text NOT NULL,
  `soyad` text NOT NULL,
  `eposta` text NOT NULL,
  `sifre` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `tbl_kullanici`
--

INSERT INTO `tbl_kullanici` (`ad`, `soyad`, `eposta`, `sifre`) VALUES
('Muhammet', 'Yorulmaz', 'muhammet@baskent.edu.tr', '1998');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_personeller`
--

CREATE TABLE `tbl_personeller` (
  `notlar` text NOT NULL,
  `ad` text NOT NULL,
  `soyad` text NOT NULL,
  `unvan` text NOT NULL,
  `bolum` text NOT NULL,
  `odanumarası` text NOT NULL,
  `isebaslamatarihi` text NOT NULL,
  `marka` text NOT NULL,
  `model` text NOT NULL,
  `aciklama` text NOT NULL,
  `demirbasno` int(7) NOT NULL,
  `isletimsistemi` text NOT NULL,
  `islemcimarkamodel` text NOT NULL,
  `ram` int(7) NOT NULL,
  `diskkapasitesi` int(7) NOT NULL,
  `ekrankartı` text NOT NULL,
  `hız` int(7) NOT NULL,
  `cekirdek` int(7) NOT NULL,
  `boyut` float NOT NULL,
  `verildigitarih` text NOT NULL,
  `eposta` text NOT NULL,
  `sicilno` int(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `tbl_personeller`
--

INSERT INTO `tbl_personeller` (`notlar`, `ad`, `soyad`, `unvan`, `bolum`, `odanumarası`, `isebaslamatarihi`, `marka`, `model`, `aciklama`, `demirbasno`, `isletimsistemi`, `islemcimarkamodel`, `ram`, `diskkapasitesi`, `ekrankartı`, `hız`, `cekirdek`, `boyut`, `verildigitarih`, `eposta`, `sicilno`) VALUES
('Laptop bakımı yapılacak', 'TUĞBA', 'ALTINAĞ', 'ÖGR.GÖR.DR.', 'Bilp.', 'A-202', '2017-05-01 16:47:00', 'LENOVA', 'V15', 'Laptop verildi', 1160, 'DOS', 'NVIDA', 16, 32, 'NVIDA', 144, 4, 17.6, '2024-04-01 18:51:05', 'tugba@baskent.edu.tr', 116),
('Sistem sorumlusu', 'MUHAMMET', 'YORULMAZ', 'PROF.DR.ÖGR.GÖR.', 'END.', 'A-2800', '1998-05-03 16:52:26', 'APPLE', 'MACBOOK - PRO', 'Laptop bakımı yapılacak', 1150, 'MAC-OS', 'IOS', 32, 32, 'NVIDIA Quadro FX 4500', 122, 4, 15, '2024-02-02 17:50:56', 'muhammet@baskent.edu.tr', 115),
('Laptop', 'DEFNE', 'KAS', 'ÖGR.GÖR.DR.', 'İNS.', 'H-302', '2007-05-01 16:47:00', 'HP', 'T-40', 'Laptop', 1170, 'DOS', 'NVIDA', 64, 64, 'NVIDA', 144, 6, 17, '2023-01-01 01:00:47', 'defne@baskent.edeu.tr', 117),
('Laptop bakım için alındı', 'FURKAN', 'BAL', 'ÖGR.GÖR.', 'END.', 'E-603', '2012-01-01 01:00:00', 'HP', 'PAVILION', 'Gaming Pro Laptop', 1180, 'DOS', 'Thin-Client', 64, 32, 'NVIDA', 144, 4, 15.5, '2022-01-01 01:00', 'furkan@baskent.edu.tr', 118),
('Ekran kartı değişecek', 'HÜLYA', 'AY', 'ÖGR.GÖR.', 'BİLP.', 'A-202', '2022-01-01 01:00:00', 'LENOVA', 'T-40', ' Laptop', 1190, 'DOS', 'Thin-Client', 32, 64, 'NVIDA', 144, 4, 15.5, '2022-01-01 01:00:20', 'hulya@baskent.edu.tr', 119),
('Laptop teslim edildi', 'BÜŞRA', 'ÇÖL', 'ÖGR.GÖR.', 'BMET.', 'B-302', '2022-01-01 01:00:00', 'LENOVA', 'V15', ' Laptop', 1200, 'DOS', 'thin-Client', 128, 128, 'NVIDA', 144, 6, 15.5, '2022-02-01 01:00:00', 'busra@baskent.edu.tr', 120),
('Klavye bakımı yapıldı', 'DERYA', 'SAN', 'ÖGR.GÖR.', 'SBTS.', 'A-303', '2022-01-01 01:00:00', 'HP', 'VİCTUS', ' Laptop', 1210, 'DOS', 'Thin-Client', 128, 128, 'NVIDA', 256, 256, 17.1, '2023-03-02 01:00:00', 'derya@baskent.edu.tr', 121);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `tbl_personeller`
--
ALTER TABLE `tbl_personeller`
  ADD UNIQUE KEY `eposta` (`eposta`) USING HASH;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
