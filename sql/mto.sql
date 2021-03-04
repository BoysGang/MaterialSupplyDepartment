-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Мар 04 2021 г., 14:48
-- Версия сервера: 10.4.17-MariaDB
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `mto3`
--

-- --------------------------------------------------------

--
-- Структура таблицы `contract`
--

CREATE TABLE `contract` (
  `PK_Contract` int(11) NOT NULL,
  `ContractNumber` varchar(50) DEFAULT NULL,
  `ConclusionDate` date DEFAULT NULL,
  `ExpiredDate` date DEFAULT NULL,
  `PK_Provider` int(11) DEFAULT NULL,
  `PK_Warehouse` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `contract`
--

INSERT INTO `contract` (`PK_Contract`, `ContractNumber`, `ConclusionDate`, `ExpiredDate`, `PK_Provider`, `PK_Warehouse`) VALUES
(1, '035386834067', '2021-03-04', '2021-09-04', 1, 2),
(2, '305990325594', '2021-03-04', '2021-06-04', 5, 1),
(3, '320116143306', '2021-02-02', '2021-03-02', 3, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `contractline`
--

CREATE TABLE `contractline` (
  `PK_ContractLine` int(11) NOT NULL,
  `PK_Resource` int(11) DEFAULT NULL,
  `Amount` float DEFAULT NULL,
  `DeliveryPeriod` int(11) DEFAULT NULL,
  `PK_Contract` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `contractline`
--

INSERT INTO `contractline` (`PK_ContractLine`, `PK_Resource`, `Amount`, `DeliveryPeriod`, `PK_Contract`) VALUES
(1, 5, 100, 7, 1),
(2, 4, 1000, 30, 1),
(3, 7, 5, 60, 2),
(4, 8, 1, 30, 2),
(5, 2, 1000, 30, 3),
(6, 1, 1200, 30, 3);

-- --------------------------------------------------------

--
-- Структура таблицы `provider`
--

CREATE TABLE `provider` (
  `PK_Provider` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `INN` varchar(100) DEFAULT NULL,
  `Address` varchar(200) DEFAULT NULL,
  `PhoneNumber` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `provider`
--

INSERT INTO `provider` (`PK_Provider`, `Name`, `INN`, `Address`, `PhoneNumber`) VALUES
(1, 'Коновалова Лейла Михайловна', '435742342508', '357875, г. Ермаковское, ул. Генерала Антонова, 185, 320', '+7 (989) 087-88-81'),
(2, 'Голубева Алика Тимуровна', '566849331252', '143362, г. Кудымкар, ул. Локомотивная, 78, 560', '+7 (923) 180-02-01'),
(3, 'Новиков Осип Всеволодович', '036038837214', '174520, г. Дворкино, ул. Рубинштейна,  55,  36', '+7 (936) 252-60-22'),
(4, 'Вишняков Казимир Тимофеевич', '419443644463', '164288, г. Жирновск, ул. Бронный 16-й пер, 5, 152', '+7 (983) 208-87-98'),
(5, 'Титов Кирилл Богуславович', '084387463401', '249134, г. Нема, ул. Лонгиновская, 109, 398', '+7 (961) 831-03-10');

-- --------------------------------------------------------

--
-- Структура таблицы `receiptorder`
--

CREATE TABLE `receiptorder` (
  `PK_ReceiptOrder` int(11) NOT NULL,
  `ReceiptOrderNumber` varchar(50) DEFAULT NULL,
  `CreateDate` date DEFAULT NULL,
  `PK_Warehouse` int(11) DEFAULT NULL,
  `PK_Provider` int(11) DEFAULT NULL,
  `PK_Contract` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `receiptorder`
--

INSERT INTO `receiptorder` (`PK_ReceiptOrder`, `ReceiptOrderNumber`, `CreateDate`, `PK_Warehouse`, `PK_Provider`, `PK_Contract`) VALUES
(1, '000001', '2021-03-02', 2, 3, 3);

-- --------------------------------------------------------

--
-- Структура таблицы `receiptorderline`
--

CREATE TABLE `receiptorderline` (
  `PK_ReceiptOrderLine` int(11) NOT NULL,
  `AcceptedAmount` float DEFAULT NULL,
  `PK_ReceiptOrder` int(11) DEFAULT NULL,
  `PK_Resource` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `receiptorderline`
--

INSERT INTO `receiptorderline` (`PK_ReceiptOrderLine`, `AcceptedAmount`, `PK_ReceiptOrder`, `PK_Resource`) VALUES
(1, 1000, 1, 2),
(2, 1200, 1, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `resource`
--

CREATE TABLE `resource` (
  `PK_Resource` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Cipher` varchar(50) DEFAULT NULL,
  `FactoryNumber` varchar(50) DEFAULT NULL,
  `PK_Unit` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `resource`
--

INSERT INTO `resource` (`PK_Resource`, `Name`, `Cipher`, `FactoryNumber`, `PK_Unit`) VALUES
(1, 'Плита древесно-стружечная', '16.21.13.000', '000001', 6),
(2, 'Плита древесно-волокнистая', '16.21.14.000', '000002', 6),
(3, 'Мебельная направляющая', '25.72.14.130', '000003', 2),
(4, 'Обивочная ткань', '13.20.41.110', '000004', 4),
(5, 'Клей-расплав', '20.52.10.110', '000005', 5),
(6, 'Винт самонарезающийся', '25.94.11.110', '000006', 2),
(7, 'Форматно-раскроечный станок мод. FL-3200F', '28.49.12.119', '000007', 2),
(8, 'Автомотический кромкооблицовочный станок FILATO Optima 264', '28.49.12.119', '000008', 2);

-- --------------------------------------------------------

--
-- Структура таблицы `unit`
--

CREATE TABLE `unit` (
  `PK_Unit` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Cipher` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `unit`
--

INSERT INTO `unit` (`PK_Unit`, `Name`, `Cipher`) VALUES
(1, 'Кг', '166'),
(2, 'Шт', '796'),
(3, 'Г', '163'),
(4, 'М', '006'),
(5, 'М3', '113'),
(6, 'М2', '055');

-- --------------------------------------------------------

--
-- Структура таблицы `warehouse`
--

CREATE TABLE `warehouse` (
  `PK_Warehouse` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Cipher` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `warehouse`
--

INSERT INTO `warehouse` (`PK_Warehouse`, `Name`, `Cipher`) VALUES
(1, 'Склад оборудования', '007'),
(2, 'Склад материалов', '002');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `contract`
--
ALTER TABLE `contract`
  ADD PRIMARY KEY (`PK_Contract`),
  ADD KEY `IX_Relationship9` (`PK_Provider`),
  ADD KEY `IX_Relationship10` (`PK_Warehouse`);

--
-- Индексы таблицы `contractline`
--
ALTER TABLE `contractline`
  ADD PRIMARY KEY (`PK_ContractLine`),
  ADD KEY `IX_Relationship11` (`PK_Resource`),
  ADD KEY `IX_Relationship13` (`PK_Contract`);

--
-- Индексы таблицы `provider`
--
ALTER TABLE `provider`
  ADD PRIMARY KEY (`PK_Provider`);

--
-- Индексы таблицы `receiptorder`
--
ALTER TABLE `receiptorder`
  ADD PRIMARY KEY (`PK_ReceiptOrder`),
  ADD KEY `IX_Relationship30` (`PK_Warehouse`),
  ADD KEY `IX_Relationship31` (`PK_Provider`),
  ADD KEY `IX_Relationship32` (`PK_Contract`);

--
-- Индексы таблицы `receiptorderline`
--
ALTER TABLE `receiptorderline`
  ADD PRIMARY KEY (`PK_ReceiptOrderLine`),
  ADD KEY `IX_Relationship33` (`PK_ReceiptOrder`),
  ADD KEY `IX_Relationship34` (`PK_Resource`);

--
-- Индексы таблицы `resource`
--
ALTER TABLE `resource`
  ADD PRIMARY KEY (`PK_Resource`),
  ADD KEY `IX_Relationship28` (`PK_Unit`);

--
-- Индексы таблицы `unit`
--
ALTER TABLE `unit`
  ADD PRIMARY KEY (`PK_Unit`);

--
-- Индексы таблицы `warehouse`
--
ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`PK_Warehouse`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `contract`
--
ALTER TABLE `contract`
  MODIFY `PK_Contract` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `contractline`
--
ALTER TABLE `contractline`
  MODIFY `PK_ContractLine` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `provider`
--
ALTER TABLE `provider`
  MODIFY `PK_Provider` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `receiptorder`
--
ALTER TABLE `receiptorder`
  MODIFY `PK_ReceiptOrder` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `receiptorderline`
--
ALTER TABLE `receiptorderline`
  MODIFY `PK_ReceiptOrderLine` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `resource`
--
ALTER TABLE `resource`
  MODIFY `PK_Resource` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `unit`
--
ALTER TABLE `unit`
  MODIFY `PK_Unit` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `warehouse`
--
ALTER TABLE `warehouse`
  MODIFY `PK_Warehouse` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `contract`
--
ALTER TABLE `contract`
  ADD CONSTRAINT `Relationship10` FOREIGN KEY (`PK_Warehouse`) REFERENCES `warehouse` (`PK_Warehouse`),
  ADD CONSTRAINT `Relationship9` FOREIGN KEY (`PK_Provider`) REFERENCES `provider` (`PK_Provider`);

--
-- Ограничения внешнего ключа таблицы `contractline`
--
ALTER TABLE `contractline`
  ADD CONSTRAINT `Relationship11` FOREIGN KEY (`PK_Resource`) REFERENCES `resource` (`PK_Resource`),
  ADD CONSTRAINT `Relationship13` FOREIGN KEY (`PK_Contract`) REFERENCES `contract` (`PK_Contract`);

--
-- Ограничения внешнего ключа таблицы `receiptorder`
--
ALTER TABLE `receiptorder`
  ADD CONSTRAINT `Relationship30` FOREIGN KEY (`PK_Warehouse`) REFERENCES `warehouse` (`PK_Warehouse`),
  ADD CONSTRAINT `Relationship31` FOREIGN KEY (`PK_Provider`) REFERENCES `provider` (`PK_Provider`),
  ADD CONSTRAINT `Relationship32` FOREIGN KEY (`PK_Contract`) REFERENCES `contract` (`PK_Contract`);

--
-- Ограничения внешнего ключа таблицы `receiptorderline`
--
ALTER TABLE `receiptorderline`
  ADD CONSTRAINT `Relationship33` FOREIGN KEY (`PK_ReceiptOrder`) REFERENCES `receiptorder` (`PK_ReceiptOrder`),
  ADD CONSTRAINT `Relationship34` FOREIGN KEY (`PK_Resource`) REFERENCES `resource` (`PK_Resource`);

--
-- Ограничения внешнего ключа таблицы `resource`
--
ALTER TABLE `resource`
  ADD CONSTRAINT `Relationship28` FOREIGN KEY (`PK_Unit`) REFERENCES `unit` (`PK_Unit`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
