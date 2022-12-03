
-- База данных: `settlement`
--
CREATE DATABASE IF NOT EXISTS `settlement` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `settlement`;

-- --------------------------------------------------------

--
-- Структура таблицы `auto`
--

CREATE TABLE `auto` (
  `Id` int(11) NOT NULL,
  `DateDel` date NOT NULL,
  `TypeCon` int(4) NOT NULL,
  `NumCon` varchar(50) NOT NULL,
  `id_client` int(11) NOT NULL,
  `Adress` varchar(50) NOT NULL,
  `Zpu` int(7) NOT NULL DEFAULT 0,
  `HoursPause` int(7) NOT NULL DEFAULT 0,
  `OptAdress` int(7) NOT NULL DEFAULT 0,
  `OverLoad` int(7) NOT NULL DEFAULT 0,
  `Expe` int(7) NOT NULL DEFAULT 0,
  `DateOplata` varchar(50) NOT NULL DEFAULT '0',
  `id_drivers` int(11) NOT NULL,
  `id_mkad1` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `auto`
--

INSERT INTO `auto` (`Id`, `DateDel`, `TypeCon`, `NumCon`, `id_client`, `Adress`, `Zpu`, `HoursPause`, `OptAdress`, `OverLoad`, `Expe`, `DateOplata`, `id_drivers`, `id_mkad1`) VALUES
(1, '2021-01-24', 40, 'TKRU3100538', 36, '20', 0, 0, 0, 0, 0, '10 от 17/01', 1, 6),
(13, '2021-01-22', 40, 'RZDU5261855', 43, '0', 0, 0, 0, 0, 0, '45 от 28/01', 5, 8),
(14, '2021-01-04', 20, 'TLLU4250149', 44, '10', 0, 0, 0, 0, 0, '1 от 13/01', 6, 7),
(15, '2021-01-05', 20, 'MEDU9400504', 46, '26', 0, 0, 0, 0, 0, '1 от 13/01', 7, 10),
(16, '2021-01-05', 20, 'TKRU3156711', 40, '26', 0, 0, 0, 0, 0, '', 5, 11),
(17, '2021-01-12', 40, 'BMOU5951730', 42, '0', 0, 4, 1500, 0, 0, '13 от 17/01', 4, 12),
(18, '2021-01-20', 40, 'TCKU1714852', 44, '25', 0, 2, 0, 0, 0, '', 5, 14),
(19, '2021-01-22', 40, 'TKRU4244083', 44, '17', 0, 0, 0, 0, 0, '44 от 28/0', 5, 4),
(20, '2021-01-16', 40, 'TKRU3318387', 40, '12', 500, 6, 0, 0, 0, '', 2, 7),
(21, '2021-01-07', 20, 'TKRU4379598', 47, '4', 0, 0, 0, 0, 0, '', 4, 12),
(22, '2021-01-07', 20, 'RDMU2490399', 37, '0', 0, 0, 0, 0, 0, '56 от 01/02', 1, 14),
(23, '2021-01-20', 20, 'TKRU3134733', 42, '0', 500, 2, 1500, 0, 0, '54 от 01/02', 6, 6),
(24, '2021-01-20', 40, 'XINU4049083', 45, '12', 0, 3, 0, 0, 0, '', 5, 6),
(25, '2021-01-28', 40, 'TGHU7544699', 43, '100', 0, 0, 1500, 0, 0, '', 2, 12),
(26, '2021-01-29', 40, 'CAAU5283812', 42, '12', 500, 0, 0, 0, 0, '56 от 01/02', 4, 9),
(27, '2021-01-27', 20, 'FESU5105883', 45, '0', 1500, 0, 0, 7000, 0, '', 5, 11),
(28, '2021-01-14', 20, 'HCIU2071140', 40, '12', 500, 2, 1500, 0, 0, '', 7, 14),
(29, '2021-01-20', 20, 'TGHU8859237', 47, '10', 0, 0, 0, 0, 0, '', 2, 12),
(30, '2021-01-12', 20, 'HCIU2071140', 43, '20', 500, 4, 0, 1500, 0, '', 6, 11),
(31, '2021-01-14', 40, 'FESU5105883', 42, '20', 500, 0, 0, 0, 0, '', 1, 13);

-- --------------------------------------------------------

--
-- Структура таблицы `clients`
--

CREATE TABLE `clients` (
  `id` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Cost_downtime` int(11) DEFAULT NULL,
  `Cost_mkad` int(11) NOT NULL,
  `Stavka20` int(11) DEFAULT NULL,
  `Stavka40` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `clients`
--

INSERT INTO `clients` (`id`, `Name`, `Cost_downtime`, `Cost_mkad`, `Stavka20`, `Stavka40`) VALUES
(36, 'юнит', 1000, 75, 10500, 11500),
(37, 'аспект', 1000, 80, 10500, 11500),
(40, 'профит', 1000, 75, 10500, 11500),
(42, 'рекит', 1000, 70, 10000, 11000),
(43, 'амикс', 1000, 70, 10000, 11000),
(44, 'тимси', 1000, 70, 11600, 12600),
(45, 'линес', 1000, 75, 10500, 11500),
(46, 'маском', 1000, 75, 10500, 11500),
(47, 'куб', 1000, 75, 11000, 12000);

-- --------------------------------------------------------

--
-- Структура таблицы `drivers`
--

CREATE TABLE `drivers` (
  `id` int(11) NOT NULL,
  `NameD` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `drivers`
--

INSERT INTO `drivers` (`id`, `NameD`) VALUES
(1, 'Сенин 288'),
(2, 'Колосов 289'),
(4, 'Матыско 384'),
(5, 'Членов 079'),
(6, 'Джаватханов 864'),
(7, 'Политыко 079');

-- --------------------------------------------------------

--
-- Структура таблицы `mkad`
--

CREATE TABLE `mkad` (
  `id` int(11) NOT NULL,
  `taking` varchar(50) NOT NULL,
  `setting` varchar(35) NOT NULL,
  `mkad_km` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `mkad`
--

INSERT INTO `mkad` (`id`, `taking`, `setting`, `mkad_km`) VALUES
(2, 'кунц', 'лобня', 25),
(4, 'ховр', 'ппжт', 0),
(5, 'угли', 'ппжт', 26),
(6, 'кунц', 'угли', 26),
(7, 'угли', 'купав', 26),
(8, 'селятино', 'ппжт', 35),
(9, 'домодедово', 'ступино', 105),
(10, 'бутово', 'ступино', 95),
(11, 'ворс', 'кунц', 0),
(12, 'угли', 'домодедово', 41),
(13, 'купав', 'кунц', 25),
(14, 'купав', 'черный', 40);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `auto`
--
ALTER TABLE `auto`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `id_client` (`id_client`),
  ADD KEY `id_mkad1` (`id_mkad1`),
  ADD KEY `id_drivers` (`id_drivers`);

--
-- Индексы таблицы `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `drivers`
--
ALTER TABLE `drivers`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `mkad`
--
ALTER TABLE `mkad`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `auto`
--
ALTER TABLE `auto`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT для таблицы `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT для таблицы `drivers`
--
ALTER TABLE `drivers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `mkad`
--
ALTER TABLE `mkad`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `auto`
--
ALTER TABLE `auto`
  ADD CONSTRAINT `auto_ibfk_1` FOREIGN KEY (`id_client`) REFERENCES `clients` (`id`),
  ADD CONSTRAINT `auto_ibfk_2` FOREIGN KEY (`id_mkad1`) REFERENCES `mkad` (`id`),
  ADD CONSTRAINT `auto_ibfk_3` FOREIGN KEY (`id_drivers`) REFERENCES `drivers` (`id`);
--
