-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 01, 2022 at 02:50 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `new_master_trade`
--

-- --------------------------------------------------------

--
-- Table structure for table `bitacora`
--

CREATE TABLE `bitacora` (
  `id_bit` int(15) NOT NULL,
  `id_usu` int(15) NOT NULL,
  `mod_bit` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  `acc_bit` varchar(200) COLLATE utf8_spanish_ci NOT NULL,
  `fec_bit` date NOT NULL,
  `hor_bit` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `bitacora`
--

INSERT INTO `bitacora` (`id_bit`, `id_usu`, `mod_bit`, `acc_bit`, `fec_bit`, `hor_bit`) VALUES
(1, 8, 'CIERRE DE SESIÓN', 'El usuario 29561173 cerró su sesión en el sistema', '2022-11-30', '18:35:32'),
(2, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-11-30', '18:35:40'),
(3, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-11-30', '18:37:22'),
(4, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-11-30', '18:37:55'),
(5, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-11-30', '18:47:37'),
(6, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-11-30', '19:02:53'),
(7, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-11-30', '19:04:42'),
(8, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '07:41:29'),
(9, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '07:43:32'),
(10, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '08:07:11'),
(11, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '08:09:28'),
(12, 8, 'CLIENTES', 'El usuario 29561173 actualizó la entrada de V29561173 en el sistema', '2022-12-01', '08:10:11'),
(13, 8, 'PROVEEDORES', 'El usuario 29561173 actualizó la entrada de V13509897 en el sistema', '2022-12-01', '08:12:08'),
(14, 8, 'COMPRAR', 'El usuario 29561173 registró la compra 000000001 en el sistema', '2022-12-01', '08:12:43'),
(15, 8, 'VENDER', 'El usuario 29561173 registró la venta 000000001 en el sistema', '2022-12-01', '08:14:08'),
(16, 8, 'CIERRE DE SESIÓN', 'El usuario 29561173 cerró su sesión en el sistema', '2022-12-01', '08:14:41'),
(17, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '08:20:53'),
(18, 8, 'COMPRAR', 'El usuario 29561173 registró la compra 000000002 en el sistema', '2022-12-01', '08:22:06'),
(19, 8, 'VENDER', 'El usuario 29561173 registró la venta 000000002 en el sistema', '2022-12-01', '08:23:09'),
(20, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '08:40:26'),
(21, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '08:41:11'),
(22, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '08:43:43'),
(23, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '08:45:04'),
(24, 8, 'CIERRE DE SESIÓN', 'El usuario 29561173 cerró su sesión en el sistema', '2022-12-01', '08:45:42'),
(25, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '08:46:26'),
(26, 8, 'CIERRE DE SESIÓN', 'El usuario 29561173 cerró su sesión en el sistema', '2022-12-01', '08:49:22'),
(27, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '08:51:21'),
(28, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '08:54:31'),
(29, 8, 'VENDER', 'El usuario 29561173 registró la venta 000000003 en el sistema', '2022-12-01', '08:56:33'),
(30, 8, 'VENDER', 'El usuario 29561173 registró la venta 000000004 en el sistema', '2022-12-01', '08:58:20'),
(31, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '08:59:50'),
(32, 8, 'VENDER', 'El usuario 29561173 registró la venta 000000005 en el sistema', '2022-12-01', '09:00:43'),
(33, 8, 'CIERRE DE SESIÓN', 'El usuario 29561173 cerró su sesión en el sistema', '2022-12-01', '09:01:07'),
(34, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '09:05:09'),
(35, 8, 'CLIENTES', 'El usuario 29561173 actualizó la entrada de V20640360 en el sistema', '2022-12-01', '09:06:27'),
(36, 8, 'PROVEEDORES', 'El usuario 29561173 actualizó la entrada de V7589621 en el sistema', '2022-12-01', '09:10:01'),
(37, 8, 'VENDER', 'El usuario 29561173 registró la venta 000000006 en el sistema', '2022-12-01', '09:14:47'),
(38, 8, 'COMPRAR', 'El usuario 29561173 registró la compra 000000003 en el sistema', '2022-12-01', '09:17:28'),
(39, 8, 'CIERRE DE SESIÓN', 'El usuario 29561173 cerró su sesión en el sistema', '2022-12-01', '09:27:58'),
(40, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '09:30:46'),
(41, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '09:34:19'),
(42, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '09:46:47'),
(43, 8, 'INICIO DE SESIÓN', 'El usuario 29561173 inició sesión en el sistema', '2022-12-01', '09:48:49'),
(44, 8, 'CIERRE DE SESIÓN', 'El usuario 29561173 cerró su sesión en el sistema', '2022-12-01', '09:49:36');

-- --------------------------------------------------------

--
-- Table structure for table `categoria`
--

CREATE TABLE `categoria` (
  `id_cat` int(15) NOT NULL,
  `nom_cat` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `act_cat` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `categoria`
--

INSERT INTO `categoria` (`id_cat`, `nom_cat`, `act_cat`) VALUES
(19, 'COMPUTADORAS', 1),
(20, 'CÁMARA', 1),
(21, 'ROPA', 1);

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
--

CREATE TABLE `cliente` (
  `id_cli` int(15) NOT NULL,
  `doc_cli` varchar(10) COLLATE utf8_spanish_ci NOT NULL,
  `raz_cli` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `dir_cli` varchar(500) COLLATE utf8_spanish_ci NOT NULL,
  `tel_cli` varchar(15) COLLATE utf8_spanish_ci NOT NULL,
  `cor_cli` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `act_cli` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `cliente`
--

INSERT INTO `cliente` (`id_cli`, `doc_cli`, `raz_cli`, `dir_cli`, `tel_cli`, `cor_cli`, `act_cli`) VALUES
(12, 'V29561173', 'Nelson Pérez', 'Las casitas', '04127586034', 'sagitario20120@gmail.com', 0),
(13, 'V20640360', 'Luis Jonas Reyes', 'Tucupita', '04245698741', 'luis123@gmail.com', 1);

-- --------------------------------------------------------

--
-- Table structure for table `detalle_compra`
--

CREATE TABLE `detalle_compra` (
  `id_dco` int(15) NOT NULL,
  `id_oco` int(15) NOT NULL,
  `id_pro` int(15) NOT NULL,
  `can_dco` int(10) NOT NULL,
  `tot_dco` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `detalle_compra`
--

INSERT INTO `detalle_compra` (`id_dco`, `id_oco`, `id_pro`, `can_dco`, `tot_dco`) VALUES
(56, 1, 24, 10, '3000.00'),
(57, 2, 25, 12, '1200.00'),
(58, 3, 26, 20, '10000.00');

-- --------------------------------------------------------

--
-- Table structure for table `detalle_venta`
--

CREATE TABLE `detalle_venta` (
  `id_dve` int(15) NOT NULL,
  `id_ove` int(15) NOT NULL,
  `id_pro` int(15) NOT NULL,
  `can_dve` int(10) NOT NULL,
  `tot_dve` float(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `detalle_venta`
--

INSERT INTO `detalle_venta` (`id_dve`, `id_ove`, `id_pro`, `can_dve`, `tot_dve`) VALUES
(41, 1, 24, 1, 250.00),
(42, 2, 24, 1, 250.00),
(43, 2, 25, 2, 180.00),
(44, 3, 24, 3, 750.00),
(45, 4, 25, 2, 180.00),
(46, 5, 25, 3, 270.00),
(47, 6, 24, 5, 1250.00);

-- --------------------------------------------------------

--
-- Table structure for table `factura_venta`
--

CREATE TABLE `factura_venta` (
  `id_fve` int(15) NOT NULL,
  `id_ven` int(15) NOT NULL,
  `id_ove` int(15) NOT NULL,
  `id_imp` int(15) NOT NULL,
  `id_mpa` int(15) NOT NULL,
  `tim_fve` decimal(10,2) NOT NULL,
  `tot_fve` decimal(10,2) NOT NULL,
  `act_fve` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `factura_venta`
--

INSERT INTO `factura_venta` (`id_fve`, `id_ven`, `id_ove`, `id_imp`, `id_mpa`, `tim_fve`, `tot_fve`, `act_fve`) VALUES
(13, 3, 1, 6, 6, '40.00', '290.00', 1),
(14, 3, 2, 6, 6, '68.80', '498.80', 1),
(15, 3, 3, 7, 6, '13.73', '90.03', 1),
(16, 3, 4, 6, 6, '2.93', '21.24', 1),
(17, 3, 5, 6, 7, '4.40', '31.87', 1),
(18, 3, 6, 6, 6, '15.87', '115.08', 1);

-- --------------------------------------------------------

--
-- Table structure for table `garantia`
--

CREATE TABLE `garantia` (
  `id_gar` int(15) NOT NULL,
  `id_dve` int(15) NOT NULL,
  `fin_gar` date NOT NULL,
  `ffi_gar` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `garantia`
--

INSERT INTO `garantia` (`id_gar`, `id_dve`, `fin_gar`, `ffi_gar`) VALUES
(1, 41, '2022-12-01', '2023-12-01'),
(2, 42, '2022-12-01', '2023-12-01'),
(3, 43, '2022-12-01', '2022-12-31'),
(4, 44, '2022-12-01', '2023-12-01'),
(5, 45, '2022-12-01', '2022-12-31'),
(6, 46, '2022-12-01', '2022-12-31'),
(7, 47, '2022-12-01', '2023-12-01');

-- --------------------------------------------------------

--
-- Table structure for table `impuesto`
--

CREATE TABLE `impuesto` (
  `id_imp` int(15) NOT NULL,
  `des_imp` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `por_imp` decimal(10,2) NOT NULL,
  `act_imp` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `impuesto`
--

INSERT INTO `impuesto` (`id_imp`, `des_imp`, `por_imp`, `act_imp`) VALUES
(6, 'IVA', '16.00', 1),
(7, 'IVA2', '18.00', 1),
(8, 'IVA3', '10.00', 1);

-- --------------------------------------------------------

--
-- Table structure for table `marca`
--

CREATE TABLE `marca` (
  `id_mar` int(15) NOT NULL,
  `nom_mar` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `act_mar` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `marca`
--

INSERT INTO `marca` (`id_mar`, `nom_mar`, `act_mar`) VALUES
(7, 'LENOVO', 1),
(8, 'NIKE', 1);

-- --------------------------------------------------------

--
-- Table structure for table `metodo_pago`
--

CREATE TABLE `metodo_pago` (
  `id_mpa` int(15) NOT NULL,
  `des_mpa` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  `act_mpa` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `metodo_pago`
--

INSERT INTO `metodo_pago` (`id_mpa`, `des_mpa`, `act_mpa`) VALUES
(6, 'Efectivo', 1),
(7, 'PAGO MÓVIL', 1),
(8, 'ZELLE', 1);

-- --------------------------------------------------------

--
-- Table structure for table `modelo`
--

CREATE TABLE `modelo` (
  `id_mod` int(15) NOT NULL,
  `nom_mod` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `act_mod` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `modelo`
--

INSERT INTO `modelo` (`id_mod`, `nom_mod`, `act_mod`) VALUES
(4, 'INALÁMBRICO', 1),
(5, 'DEPOTIVO', 1);

-- --------------------------------------------------------

--
-- Table structure for table `moneda`
--

CREATE TABLE `moneda` (
  `id_mon` int(15) NOT NULL,
  `nom_mon` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `act_mon` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `moneda`
--

INSERT INTO `moneda` (`id_mon`, `nom_mon`, `act_mon`) VALUES
(4, 'BOLÍVAR FUERTE', 1),
(5, 'DÓLAR AMERICANO ($)', 1),
(6, 'EURO', 1),
(7, 'REAL BRASILEÑO', 1),
(8, 'LIBRA DE LONDRES', 1);

-- --------------------------------------------------------

--
-- Table structure for table `orden_compra`
--

CREATE TABLE `orden_compra` (
  `id_oco` int(15) NOT NULL,
  `id_prv` int(15) NOT NULL,
  `id_tca` int(15) NOT NULL,
  `num_oco` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `tot_oco` decimal(10,2) NOT NULL,
  `fec_oco` date NOT NULL,
  `hor_oco` time NOT NULL,
  `act_oco` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `orden_compra`
--

INSERT INTO `orden_compra` (`id_oco`, `id_prv`, `id_tca`, `num_oco`, `tot_oco`, `fec_oco`, `hor_oco`, `act_oco`) VALUES
(1, 34, 4, '000000001', '3000.00', '2022-12-01', '08:12:32', 1),
(2, 34, 4, '000000002', '1200.00', '2022-12-01', '08:21:59', 1),
(3, 35, 7, '000000003', '1017.29', '2022-12-01', '09:17:06', 1);

-- --------------------------------------------------------

--
-- Table structure for table `orden_venta`
--

CREATE TABLE `orden_venta` (
  `id_ove` int(15) NOT NULL,
  `id_cli` int(15) NOT NULL,
  `id_tca` int(15) NOT NULL,
  `num_ove` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `fec_ove` datetime NOT NULL,
  `hor_ove` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `orden_venta`
--

INSERT INTO `orden_venta` (`id_ove`, `id_cli`, `id_tca`, `num_ove`, `fec_ove`, `hor_ove`) VALUES
(1, 12, 4, '000000001', '2022-12-01 00:00:00', '08:13:58'),
(2, 12, 4, '000000002', '2022-12-01 00:00:00', '08:22:49'),
(3, 12, 5, '000000003', '2022-12-01 00:00:00', '08:56:02'),
(4, 12, 5, '000000004', '2022-12-01 00:00:00', '08:58:10'),
(5, 12, 7, '000000005', '2022-12-01 00:00:00', '09:00:16'),
(6, 13, 6, '000000006', '2022-12-01 00:00:00', '09:13:49');

-- --------------------------------------------------------

--
-- Table structure for table `producto`
--

CREATE TABLE `producto` (
  `id_pro` int(15) NOT NULL,
  `id_cat` int(15) NOT NULL,
  `id_mar` int(15) NOT NULL,
  `id_mod` int(15) NOT NULL,
  `ser_pro` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `des_pro` varchar(500) COLLATE utf8_spanish_ci NOT NULL,
  `pco_pro` decimal(10,2) NOT NULL,
  `pve_pro` decimal(10,2) NOT NULL,
  `img_pro` longblob NOT NULL,
  `gar_pro` int(3) DEFAULT NULL,
  `act_pro` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `producto`
--

INSERT INTO `producto` (`id_pro`, `id_cat`, `id_mar`, `id_mod`, `ser_pro`, `des_pro`, `pco_pro`, `pve_pro`, `img_pro`, `gar_pro`, `act_pro`) VALUES
(24, 19, 7, 4, '2022121081000', 'Computadora HP de escritorio', '300.00', '250.00', 0xffd8ffe000104a46494600010101012b012b0000ffee000e41646f626500640000000001ffe10be44578696600004d4d002a000000080007011200030000000100010000011a00050000000100000062011b0005000000010000006a012800030000000100020000013100020000001f000000720132000200000014000000928769000400000001000000a6000000c6012bfff400010000012bfff40001000041646f62652050686f746f73686f702032322e32202857696e646f7773290000323032323a31313a32322031373a34323a3530000002a0020004000000010000015ea0030004000000010000015e0000000000000006010300030000000100060000011a00050000000100000114011b0005000000010000011c012800030000000100020000020100040000000100000124020200040000000100000ab80000000000000048000000010000004800000001ffd8ffed000c41646f62655f434d0001ffee000e41646f626500648000000001ffdb0084000c08080809080c09090c110b0a0b11150f0c0c0f1518131315131318110c0c0c0c0c0c110c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c010d0b0b0d0e0d100e0e10140e0e0e14140e0e0e0e14110c0c0c0c0c11110c0c0c0c0c0c110c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0cffc00011080054005403012200021101031101ffdd00040006ffc4013f0000010501010101010100000000000000030001020405060708090a0b0100010501010101010100000000000000010002030405060708090a0b1000010401030204020507060805030c33010002110304211231054151611322718132061491a1b14223241552c16233347282d14307259253f0e1f163733516a2b283264493546445c2a3743617d255e265f2b384c3d375e3f3462794a485b495c4d4e4f4a5b5c5d5e5f55666768696a6b6c6d6e6f637475767778797a7b7c7d7e7f711000202010204040304050607070605350100021103213112044151617122130532819114a1b14223c152d1f0332462e1728292435315637334f1250616a2b283072635c2d2449354a317644555367465e2f2b384c3d375e3f34694a485b495c4d4e4f4a5b5c5d5e5f55666768696a6b6c6d6e6f62737475767778797a7b7c7ffda000c03010002110311003f00ee12496767f5fe9d817fd9ed2f7dc002f656dddb6756ef712d6ee77ee2e6218e790f0c226477a8ba529088b91a74542db6aa2a7dd738575560b9ef3c001647fcede95fb97ff983ff0026b1bae75a77527b6aa43abc3ac8706bb473dffe92d03f73fc157ff5cff8bb38790cd3981389c71fd291ede1fd6629e7801713c45dbff9d7d23fe1bfedb3fde97fcebe91e377fdb67fbd72092d0ff4672ffd7ff187fdeb07de32787d8f7181d73a7750b8d18ef70b40dc1963769701f4b67ef6d57d79cb1efadedb2b71658c21cc7b796b870e0ba8c6fadd886867daebb1b911167a4d05848fcf64bdbf4ff73f3154e6be1d28107083389de3bca27fef59717300d89d0f1779258bff003b7a57ee5ffe60ff00c9ad6c6c9a32a866463bc5955825ae12383b4820fb9ae6bbe93553c9832e300ce12883a590cd1c91969120a44924944b9fffd0ee170bd55a5fd6f2980c17e46c04f6dc58c9fc5774b87ea3ff002fddff0086d9ff00555ac6f85ff3993fb9ff007516df33b47cdb591d0fa5e35cea323abb2ab591b98eae0891b87e7feea87ecae8bff97757f99ff99a87d64ff9772bfeb7ff0050c598afe18659e384ce79dce3191a8e1fd28f17f9b6bc8c412384686b793adfb2ba2ffe5dd5fe67fe6697ecae8bff0097757f99ff0099ac94949ed64ff3f3ff00170ffeaa47147f747db274f2fa3e2d5d3eccfc4cf6e65753db5bc359025c5ad8ddb9dee6ef6b957c5e95d4b32a3762e3badac12dde0b4091f487e91ec5731fff001299bff86ebfcb420f4d6e19a1c6feab6f4f7979fd0d7be0881167b0ed76e51c726410c9eae3943270094a0727a78612f9397e0fde5c446e3a5031bd0ffdfb532b0f2b0ed1565d469b0b7706920cb4e9ba585cdecba9faa9ff00247fd7acff00beae6ba88a0648f4331f9ed2c137581db8193fa2fd27d2fde5d2fd54ff00923febd67fdf543f1024f291277328dfa650fdefd09fae2bf057bba762ec24924b15b8ff00ffd1ee170fd47fe5fbbff0db3feaab5dc2e1fa8ffe282eff00c36cff00aaad637c2ff9cc9fdcff00ba8b6f99da3e6cfeb27fcbb97ff5bffa862cd5b7d7fa6f51bface4db4e2db6d4ed9b5ed6c830c6b4ff00d259ff00b23abffdc2bbfcdff6ad1e5f2e3183103388231c3f4a3fb8d79c4f14b43b9e8d4495bfd91d5ffee15dfe6ffb52fd91d5ff00ee15dfe6ff00b54bef62ff00390ff1a2b7865d8fd8dcc7ff00c4a66ffe1baff2d0aa74fe939fd4771c5ac1630c3ac7bb6b67f701f76e77f655ff00b2e4e37d56cc664d4fa5eec9adc1af104b6686ee50c5761f50e88ce956e5b306ea2d75b36ff37635c5eed7dd5eed9ea7d1dffe0d55190c63965020839e8ce8e58c21c10f5f0e3f9d90c6cc41fdcdbe5bd767372b13270ef763e530d76b4031c820fd17b1c3e931753f553fe48ffaf59ff7d587d77331f22dc6a31ec390cc3a7d27649ff08ef6cbb77e7edd9f4ff96b73eaa7fc91ff005eb3fefaa3e7a529727194c70c8ca3636fdee92fde5d80019686a28bb092492c66e3ffd2ee170fd7e8ba8ead92eb1a5adb9fead2f830e0437563ff00798e5dc2a79dd42dc5f51b553eb3d9536d63376ddce75a31c57f45dfbcb9fe4b34b164b8c44f8870f093c1b9fde6f678094459aa3dade3bf6cf54ffb9d7ff9e52fdb1d53fee75dfe715d97ed461caf4c47d98639c97e44f11b1fb3647fa0b7d5728b3a8defa580d21996fb7d0f44ba5ad7167da43acb037e8fd97f4bed6ff39fa1573ef83ff1247bfcd0dbbff36c3ed7fac3f6178ffdb1d53fee75dfe714bf6c754ffb9d77f9c575d6753b6a86bcd1b8dde89b7d4fd181e9d974bdaddf6d566eabd1f4acff003d48f5335d98adb363eac80fdf7d4e258cdaeae9a9dee1eeadf65cdaec7ff827ff00c1a5f7b1a7f4581bdbd51edc5fe6ff00e6a3daff005874f02f177751cdc867a791956db5c83b1ee2448fa26103737c577c73adfb236f6b00b1f70a431c4c026efb2ee7383777f2d0eeea76d2f14dadaabb7d46b0bdcf3e96c7b2db596eed9bfe963be9f4d3a1cf91623cb8144d88e488f97e6fd051c23acffe6bc2ee6f8aed3ead63dd474960b986b758f7d8d6b843b6b8fb3737f37746e5728cc7596d75cb1e2cadf6fa953896fb1ecab6b770ff008456156e739d96580c671f06bc5f371fcb71fdd8b2e1c2232e2e2be9b52924925419dfffd3ee102ec3aaeb3d5717076d63742222bb1b94dedfe919fe623aa9d4aa75d5d0c0c6d9fac564b5ed2e640ddad8d6fe62e631df10a3c3e2e8cf6dad63d2317696cbf638d9b84882db5f55afa4fb7f99db8d5e3b19ff0071bf469dfd3715af75acfd58cb1c0d7b58d6bd85fe9dcd6edd9ea39973e97eefe7a9fd1aabfb35cdcaa5bb297b5debd9b5d517515ee18cc6d75d7bbd9bbd3f53e97bff0058f628e3575d5f6739b5c50caed6b5b6309aebbfd577acd6b36bb652eaff0047d3dfff00717f47fe17f493d488046532bfd1afef74fd2fe698f4d8c29b87a6fe9bd7f5ed191b9aef50060d58db6a6b457e9fa7b7664d9f9a8bf646b9cd7dee75e4576547d40d8732d2c2f6bd95b18dff0005b56663d38cdb47db71dcea4d4f18ec7d4fb1cdacdf73e9a9a031efa9ff0067757b6afe76b67a7fb8a4c36e3d16b7303fd7bb06a60905ee7d8d6dec7d5b99bfd4bdbead7b92942566a5645463e900ca3f27eaebf4611f994243f777f16eb702aaf0eac26daf02b735f5bcb83ac2e63fd7066c6bbd5f7fd3f6247a7b770b45d67ae2c167afec2e2431f4359b4d7e8fa4daad7fb1b57fc22a62ac7ac5f5e6d2eb2f3e98a035a5d6398daea6d6cc3b9bfcdba9c86dbf42dafd1b3f58b3e9fa88b66101999b66352c65e719871ed0c022e272fdecb36ff39eeafd4ffa681045dccfabd56623867c7c1c5eafddf5fa95a7ee8d34dff75b0ec473ec6d9f6ab3d6a9aeadcf02a261e5b66d7b3d22cf6ecf6fb1595998edc537e1fd86a351a83864fb0b0b6b2c70f4725ce037dcec9f45fefdf67f3972d3516504100f6eb110947d457c35bd14924928d7bfffd4ee125f3924b9574dfa353899d2657ce2924a7e8ed7fbd213da7cd7ce2924a7e8e130638ee997ce4924a7e8e3302663b265f3924929fa3525f3924929ffd9ffe202404943435f50524f46494c450001010000023041444245021000006d6e74725247422058595a2007cf00060003000000000000616373704150504c000000006e6f6e65000000000000000000000000000000000000f6d6000100000000d32d4144424500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a63707274000000fc0000003264657363000001300000006b777470740000019c00000014626b7074000001b00000001472545243000001c40000000e67545243000001d40000000e62545243000001e40000000e7258595a000001f4000000146758595a00000208000000146258595a0000021c000000147465787400000000436f7079726967687420313939392041646f62652053797374656d7320496e636f72706f726174656400000064657363000000000000001141646f62652052474220283139393829000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000058595a20000000000000f35100010000000116cc58595a200000000000000000000000000000000063757276000000000000000102330000637572760000000000000001023300006375727600000000000000010233000058595a200000000000009c1800004fa5000004fc58595a20000000000000348d0000a02c00000f9558595a2000000000000026310000102f0000be9cffdb0043000604040405040605050609060506090b080606080b0c0a0a0b0a0a0c100c0c0c0c0c0c100c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0cffdb0043010707070d0c0d18101018140e0e0e14140e0e0e0e14110c0c0c0c0c11110c0c0c0c0c0c110c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0cffc0001108015e015e03011100021101031101ffc4001f0000000701010101010000000000000000040503020601000708090a0bffc400b51000020103030204020607030402060273010203110400052112314151061361227181143291a10715b14223c152d1e1331662f0247282f12543345392a2b26373c235442793a3b33617546474c3d2e2082683090a181984944546a4b456d355281af2e3f3c4d4e4f465758595a5b5c5d5e5f566768696a6b6c6d6e6f637475767778797a7b7c7d7e7f738485868788898a8b8c8d8e8f82939495969798999a9b9c9d9e9f92a3a4a5a6a7a8a9aaabacadaeafaffc4001f0100020203010101010100000000000000010002030405060708090a0bffc400b5110002020102030505040506040803036d0100021103042112314105511361220671819132a1b1f014c1d1e1234215526272f1332434438216925325a263b2c20773d235e2448317549308090a18192636451a2764745537f2a3b3c32829d3e3f38494a4b4c4d4e4f465758595a5b5c5d5e5f5465666768696a6b6c6d6e6f6475767778797a7b7c7d7e7f738485868788898a8b8c8d8e8f839495969798999a9b9c9d9e9f92a3a4a5a6a7a8a9aaabacadaeafaffdd0004002cffda000c03010002110311003f00ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd0ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd1ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1540eafade99a45b7d62fe611464d106e598f82a8dce5fa7d34f34b8602d864cb180b290ff00cacff2affbf26ff914733ff91351dd1f9b8ff9dc6eff00959fe55ff7e4dff228e3fc89a8ee8fcd7f3b8ddff2b3fcabfefc9bfe451c7f91351dd1f9afe771bbfe567f957fdf937fc8a38ff226a3ba3f35fcee377fcacff2affbf26ff91471fe44d47747e6bf9dc6eff959fe55ff007e4dff00228e3fc89a8ee8fcd7f3b8ddff002b3fcabfefc9bfe451c7f91351dd1f9afe771bbfe567f957fdf937fc8a38ff00226a3ba3f35fcee377fcacff002aff00bf26ff0091471fe44d47747e6bf9dc6e1f99de5424032ca2bdcc469f863fc8ba8ee1f35fcee364d67796b7b6c9736b2acd0482a922ee08cd664c72848c642a41ca8c8485856c825d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762afffd2ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8aa1356d56cf4bb096f6edf84310fa58f6551dd8e5d8304b2cc463ccb1c9311165e21e63f305e6b9a8b5ddc1e283e182107e18d3b01eff00cc73b8d1e923821c23fce97f39d1e6ca672b295665353b15762aec55d8abb15762aec55d8abb15651e48f384ba1ddfa1704be993b7ef53a98dba7a8bff001b0fdacd5f697678cf1b1fde47fd97f45cad36a380d1fa5ec914b14d124b13078a40191d4d41077041ce325120d1e6ee41b5f815d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157fffd3ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec554aeaeaded2da4b9b871141129691dba003270819c84622c944a400b2f15f3879aee35fbfa8ac7610922da13ff00136ff29bfe173b5ecfd08d3c3fa72faa4e97519ce43fd163f9b071dd8abb15762aec55d8abb15762aec55d8abb15762acdff002ffcea74e9574bd41ffd024348656ff7531ec7fe2b6ff85cd1f6b766f883c487d63eafe9ff00c79ced26a787d27e97ac0208a8e99c9bb5762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55fffd4ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762ad3ba2233b90a8a09663b0007524e102f60af1ff003df9c9f59b936566c46990b6c46deab8fdb3fe4ff20ff659d8765f677831e297f792ff0060e9f55a8e3343e96239b7711d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abd27f2efced5f4f45d4a4df65b29d8fdd131ff887fc0ff2e735dafd9bcf2c07f5e3feff00fe29d969353fc32ff35e8d9ce3b1762aec55d8abb15762aec55d8abb15762aec55d8abb15762afffd5ee19e6ef46ec55d8abb15762aec552ad47cd3e5ed39cc7797d1c728eb1825dc7cd5031199787439b20b8c4d354f3c23cca5fff002b17ca1ff2dc7fe454bff34e5ffc91a9fe6ffb28feb6bfcde3ef77fcac5f287fcb71ff009152ff00cd38ff00246a7f9bfeca3fad7f398fbddff2b17ca1ff002dc7fe454bff0034e3fc91a9fe6ffb28feb5fce63ef77fcac5f287fcb71ff9152ffcd38ff246a7f9bfeca3fad7f398fbddff002b17ca1ff2dc7fe454bff34e3fc91a9fe6ff00b28feb5fce63ef77fcac5f287fcb71ff009152ff00cd38ff00246a7f9bfeca3fad7f398fbd87f9efcf91ea51fe8ed2a43f52600dc4d42a64ff00200343c07ed7f366e7b2fb2ce33c7907aff863fcd70f55aae2f4c79305cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8ab60904106847438abd3bca9f99363fa3c5beb9318ee60a2a5c7167f517b72e20fc63bff3672fafec6971de217197f0ff0035d9e0d60aa9f34eff00e562f943fe5b8ffc8a97fe69cc1fe48d4ff37fd947f5b7fe731f7bbfe562f943fe5b8ffc8a97fe69c7f92353fcdff651fd6bf9cc7deeff00958be50ff96e3ff22a5ff9a71fe48d4ff37fd947f5afe731f7bbfe562f943fe5b8ff00c8a97fe69c7f92353fcdff00651fd6bf9cc7deeff958be50ff0096e3ff0022a5ff009a71fe48d4ff0037fd947f5afe731f7b63f317ca04d3ebdff24a5ff9a71fe48d4ff37fd947f5afe6f1f7a6da6ebba3ea40fd46ee39c8ea8adf10f9a9a37e19899b4b9317d71316e8658cb9147650cdd8abb15762aec55d8abfffd6ee19e6ef46ec55d8abb15762af36fcc1f3c5c25c49a3e97218c47f0dddc21a316ef1a9ed4fda39d2f64f6602064c82ff00991ff7ceb757a937c3179d1249a9dc9ea73a375cd62aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec555209e682559a0768a5435491090c0fb119194448511612091b87adf907ce4facc2d657a47e91817907e9eaa74e54fe65fdace47b57b3bc13c51feee5fec1dbe9751c628fd4cc334ee5bb15762aec55d8abfffd7ee19e6ef46ec55d8abb15436a5726d34ebaba1d60864947fb052dfc32cc30e3988ff003a422c672a892f9ee491e491a47259dc96663d4926a4e7a18000a0f3c4dadc2aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb154e3ca1752db799f4c78cd0bdc47137bacadc1bf06cc3ed080960983fcd32ff004bea6ed3caa63def77ce0ddebb15762aec55d8abffd0ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8aa65e5aff948f4aff98cb7ff0093ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157fffd1ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762af59f2f7e5be849a6412ea311babb9915deaccaabc8578a8523a789ce4b57db194cc881e18876d8b470e1f56e534ff00957be51ff9601ff2324ff9ab317f95b51fcefb22dbf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff957be51ff009601ff002324ff009ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff957be51ff009601ff002324ff009ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff957be51ff009601ff002324ff009ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff957be51ff009601ff002324ff009ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f725dae7e5ae812e9f2b69f11b5bb8d4b44c1d9958815e2c189d8fb66469bb673098e33c716bcba3811b6c5e479d7ba8762aec55d8abb15762aec55d8abb15762a99796bfe523d2bfe632dff00e4eae636b3fb99ff00525fee5b30fd71feb07bee700efdd8abb15762aec55fffd2ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f2091f997cefa7e817915adcc134af2c7ea868f8d29c8ad3e223f9733747d9b3d444ca240a3c3bb466d48c66884a3fe56de89ff002c773ff24ffe6acccfe40cbfce8ffb2fd4d3f9f8f7177fcadbd13fe58ee7fe49ff00cd58ff002065fe747fd97ea5fcfc7b8bbfe56de89ff2c773ff0024ff00e6ac7f9032ff003a3fecbf52fe7e3dc5dff2b6f44ff963b9ff00927ff3563fc8197f9d1ff65fa97f3f1ee2eff95b7a27fcb1dcff00c93ff9ab1fe40cbfce8ffb2fd4bf9f8f7177fcadbd13fe58ee7fe49ffcd58ff2065fe747fd97ea5fcfc7b8bbfe56de89ff002c773ff24ffe6ac7f9032ff3a3fecbf52fe7e3dc5dff002b6f44ff00963b9ff927ff003563fc8197f9d1ff0065fa97f3f1ee2eff0095b7a27fcb1dcffc93ff009ab1fe40cbfce8ff00b2fd4bf9f8f7177fcadbd13fe58ee7fe49ff00cd58ff002065fe747fd97ea5fcfc7b8bbfe56de89ff2c773ff0024ff00e6ac7f9032ff003a3fecbf52fe7e3dc5dff2b6f44ff963b9ff00927ff3563fc8197f9d1ff65fa97f3f1ee2eff95b7a27fcb1dcff00c93ff9ab1fe40cbfce8ffb2fd4bf9f8f7177fcadbd13fe58ee7fe49ffcd58ff2065fe747fd97ea5fcfc7b8bbfe56de89ff002c773ff24ffe6ac7f9032ff3a3fecbf52fe7e3dc5dff002b6f44ff00963b9ff927ff003563fc8197f9d1ff0065fa97f3f1ee29b796fcf5a76bd7cf676d6f344e91994b49c694040a7c24ff0036626b3b327821c52313bf0b6e1d50c86806433ff7127faa7f566be3cc392793e743d4e7a33ce358aa71e58f2ddd6bfa8fd561711468bce7988a855ad3a7727b661eb7591d3c388ee7f862dd8709c92a0ce47e516994defe6af7f853345fcbf3fe6c5cefc847bdbff9545a5ffcb7cfff000298ff002fe4fe6c57f211ef77fcaa2d2ffe5be7ff00814c7f97f27f362bf908f7a035afcaafab584b71a7ddb4d2c4a5cc12281c80152148fdacc8d376ef14c4671e107f89af26868582f3cce85d7bb15762a99796bfe523d2bfe632dffe4eae636b3fb99ff525fee5b30fd71feb07bee700efdd8abb15762aec55ffd3ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358ab26f22799adf42d4e47ba526d2e5024aca2a5483556a771e39aced4d11cf01c3f545c9d2e618e5bf22f4b1e7bf29115fd229bf8abffcd39ccff25ea3f987ec767f9ac7deeff1df94bfeae51ffc0bff00cd38ff0025ea3f987ec5fcd63ef77f8efca5ff005728ff00e05ffe69c7f92f51fcc3f62fe6b1f7a5fae7e63797edf4f97ea571f5bbb752b0c68ac0062280b16005066469bb2334a63887045af2eb2006c6cbc7b3b174eec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd4ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15762aec55d8abb15762aec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd5ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358ab22f24f96135fd4de299cc76b6ebea4c57ed1a9a0515e95f1cd77696b4e9e163ea97d2e469b0f892df93d147e5af9440ff00795cfbfab27f5ce73f96751dff00ec62ec7f278fb9dff2adbca3ff002cafff002364ff009ab1fe59d47f3bfd8c57f278fb9dff002adbca3ff2caff00f2364ff9ab1fe59d47f3bfd8c57f278fb901adfe58e88f612b69aaf6f771a968eaeceac40af160d5ebed991a6edaca2638fd516193451af4f3793e758ea5d8abb154cbcb5ff291e95ff3196fff00275731b59fdccffa92ff0072d987eb8ff583df738077eec55d8abb15762aff00ffd6ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358aa79e52f334be5fd48dc08fd68255e13c55a12b5a820ff32e60ebf443510e1ba90fa5bf066f0e56cf87e6c797a82b05c83e1c53fe6bcd07f20e6ef87dbfa9cffcfc3b8bbfe56c7977fdf173ff00009ff35e3fc859bbe1f6ff00c4afe7a1e6eff95b1e5dff007c5cff00c027fcd78ff2166ef87dbff12bf9e879a035afcd5b392c25874cb7945c4aa504b2f1509514e4002d53e197e9bb0a4260cc8e11fcd6bc9ae045446ef34ce99d6bb15762a99796bfe523d2bfe632dffe4eae636b3fb99ff525fee5b30fd71feb07bee700efdd8abb15762aec55ffd7ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15762aec55d8abb15762aec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd0ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15762aec55d8abb15762aec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd1ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15762aec55d8abb15762aec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd2ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15657e5bfcbcd5b578d6e67616566dba48e2aee3c5536dbfca6cd4eb3b5f1e13c23d7372f0e9253dcfa433183f2a7cb88804b2dc4afddb9aafe01734f2eddcc4ec221cc1a1879a0353fca4b46466d32f1e393b47380ca7db928047fc0b65f87b7e57eb8edfd16b9e807f0979feada3ea3a4ddb5adf4262946ebdd587f329e84674383510cb1e281b0ebf26330345059730762aec5532f2d7fca47a57fcc65bff00c9d5cc6d67f733fea4bfdcb661fae3fd60f7dce01dfbb15762aec55d8abfffd3ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358ab2ff00cbaf2c47ab6a2f77769cacace84a1e8f21dd54ff00923ed3669fb5f5a7143863f5cffd8c5ccd261e3959e517b00000a0d80ce3ddbb1cbffcc0f2bd94e607ba32c8a68fe8a97507fd61f0fdd9b1c5d959e62c0afeb38f3d5e389ab4d749d734bd5a03369f70b32aece0543293fcca68c33173e9b2623531c2db8f2c662c14379a3cbb6dae69725b48009d416b69bba3f6ff0062dd1b2dd16ae5832090fa7f8831cf844e34f0a9a192199e19578c91b14753d4329a119ddc64242c722e888ad966143b154cbcb5ff00291e95ff003196ff00f275731b59fdccff00a92ff72d987eb8ff00583df738077eec55d8abb15762afffd4ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abd93f2cadd22f2a42ea3e29e491dcfb86e1fa9738deda993a823f9a03b9d10ac6dfe646a97161e5b616ec524ba91602e3a856059a9f30bc70763e019336ffc038975933186dd5e359d9ba64e7ca1aadc69be60b396262164916199074649182907efa8cc2ed0c03261903d07147fcd6ed3ccc661eed9c23bd788f9fedd20f36dfaa6c1d924a7bba2b1fc4e76fd95332d3c6ff1bba4d50ac858f66c5c7762a99796bfe523d2bfe632dffe4eae636b3fb99ff525fee5b30fd71feb07bee700efdd8abb15762aec55ffd5ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abd6bf2ab518e7d064b2afef6d253f0ff009127c40ffc172ce47b73098e612e931fee5db686770aee4f7cd7a08d6f4596c83049aa2481cf4122f4afb1fb3983a1d5781944ba7f17f55bf3e2e38d3c56ff0046d534fb8682eed648a4069ba9a1f7523661f2cedb16a31e417120874b3c7289a2194f90bc99a85cea506a57b0b41656cc2441202ad23aeeb4077e20ee5b355da9da308c0c2278a72dbfaae56974c4cb88f20f59ce49db3c1fcdba8a6a3e63beba8cf289a4e31b78ac60203f4f1cef34184e3c3189e75fee9d1679f14c94a3331a5d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd6ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358aa6de59f30dc685aa25e4439c6470b886b4e687a8f98eab989add2473e3e13cff0085b70e53095bdb349d634fd5ad16eac6512c6df687ed29fe561fb27388cfa79e2970cc517778f2098b08dca59bb1560be7df3cdbda5b4ba5e9b2092f250527990d444a762011feec3ff0b9bdecaecc3390c931e81f4ff4ff00e3ae0eab5200e18f37956756ea9d8abb154cbcb5ff00291e95ff003196ff00f275731b59fdccff00a92ff72d987eb8ff00583df738077eec55d8abb15762afffd7ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f2086d4340d1b519566beb48ee2545e0aee2a42d49a7e39662d565c62a12310c678a32dc842ff00833cadff0056c83fe072dfe51cff00cf930fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee08ad3fcbfa2e9d319ec6ce3b79994a174143c49048fc32acbabcb9054a464194314626c0464ffdc49feab7eaca63cc361e4f9d4f539e8cf38d62aec551361a8dfd84e27b29dede51fb4848a8f03e3f4e57970c320a90e20ca3331360b2387f33bcd51a056921948fda78c57fe14a8cd6cbb174e4f223e2e48d6e4416a7e79f336a28639af0c7136c638408c11ee57e23f7e5f87b33063362367fa5ea6b9ea672e6520ccf68762aec55d8aa65e5aff948f4aff98cb7ff0093ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157fffd0ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762acef41fcd1b8b0b08acef6d3eb5e82848e657e0c546c03020d683be68755d88324cca32e1e2fe173f16b4c45116997fcadfb5ffab649ff002347fcd398dfe87e5fcf1fe95b3f940773bfe56fdaff00d5b24ff91a3fe69c7fd0fcbf9e3fd2aff280ee77fcadfb5ffab649ff002347fcd38ffa1f97f3c7fa55fe501dceff0095bf6bff0056c93fe468ff009a71ff0043f2fe78ff004abfca03b9dff2b7ed7fead927fc8d1ff34e3fe87e5fcf1fe957f940773bfe56fdaffd5b24ff0091a3fe69c7fd0fcbf9e3fd2aff00280ee77fcadfb5ff00ab649ff2347fcd38ff00a1f97f3c7fa55fe501dceff95bf6bff56c93fe468ff9a71ff43f2fe78ff4abfca03b9dff002b7ed7fead927fc8d1ff0034e3fe87e5fcf1fe957f940773bfe56fdaff00d5b24ff91a3fe69c7fd0fcbf9e3fd2aff280ee77fcadfb5ffab649ff002347fcd38ffa1f97f3c7fa55fe501dceff0095bf6bff0056c93fe468ff009a71ff0043f2fe78ff004abfca03b9dff2b7ed7fead927fc8d1ff34e3fe87e5fcf1fe957f940773bfe56fdaffd5b24ff0091a3fe69c7fd0fcbf9e3fd2aff00280ee77fcadfb5ff00ab649ff2347fcd38ff00a1f97f3c7fa55fe501dceff95bf6bff56c93fe468ff9a71ff43f2fe78ff4abfca03b9dff002b7ed7fead927fc8d1ff0034e3fe87e5fcf1fe957f940773bfe56fdaff00d5b24ff91a3fe69c7fd0fcbf9e3fd2aff280ee4bf5bfcd49ef2c64b5b1b4fab3cca51e777e4429d8f1000dfdf3234dd86213129cb8abf85af26b891405302cdfb80ec55d8abb15762aec55d8abb15762aec5532f2d7fca47a57fcc65bffc9d5cc6d67f733fea4bfdcb661fae3fd60f7dce01dfbb15762aec55d8abffd1ee19e6ef46ec55d8abb154bbcc5ff28fea7ff3093ffc9b6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8aa65e5aff948f4aff98cb7ff0093ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157fffd2ee19e6ef46ec55d8abb1552bab74b9b59addfec4c8d1b7c98107f5e4a13e19090fe12890b14f9f6feca7b1bd9ad275e3340e51c7b83d7e9cf42c5904e2243949e7e51313450f9631762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8ab20f226992dff99ec8203c2d9c5ccadd8088861f7b715cd7f6a6618f04aff8bd1fe99c8d2c38a63c9edf9c3bbb762aec55d8abb157ffd3ee19e6ef46ec55d8abb15762ac47cede464d6ffd36ccac5a922d0f2d96551d031ecc3f65b36fd9bda6707a65be3ff70e26a74dc7b8fa9e55a868faa69d298ef6d6481877653c4fc9bec9fa33abc3a8c7905c4893aa9e39479841e5cc1d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8aa6ba3f95f5bd5a554b4b573193f14ee0ac6bf363fc331351adc5887a8ff009bfc4db8f04a7c83d7fca9e56b4f2fd898a33eadd4b4373714a7223a01e0abdb390d76ba5a89d9da23e98bb8c180631e69de60b73b15762aec55d8abffd4ee19e6ef46ec55d8abb15762aec55a6556146008f03be20aa9fd56dbfdf29ff02325c72ef470877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0870b6b61d224ff008118f1cbbd7842af4c8a5d8abb15762aec55d8abb157ffd5ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1542ddeaba5d9b05bbbc82dd8f412c8884ff00c11196e3c1927f4c652fea86329c473202eb4d42c2f056d2e62b803a989d5c7fc293832629c3ea063fd60b1983c8da232b64ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55ffd6ee19e6ef46ec55d8abb15762ab65fee9ff00d53fab0c79a9e4f3cfc9ff00eeb55ff5a0fd526745ed07387f9dfef5d7767ff17c107f9a90493f9874e82315925855107bb4ac065dd87211c3227a4bfdeb0d70b980c8bf2c753375e5efaa39fded8486320f5e0df12feb65ff00639aeedac3c39b8872c81c9d14ee15fcd6593cd1c10493ca78c7129776f05515273531899100732e59342de0f2cd7379ab26a930a0bcbb623e619588f9287519de4631863f0c7f043f1fee5d0924cb88ff00117bde702ef985fe676a7247a5dbe936fbdcea5205e23a945236ff0064e5066ebb1708390e43f4e31f8ff62e1eb67e9111ce480fcbe9a7d1f5dd43cb576d56afa901dc02ca0569febc7c5bfd8e6476b4466c51cf1feacbf1fd1935e90984cc0bd0f39d760c2bcf3e68d421ba8341d1891a8dd15124abf69039a2aa9eccdd4b7ec2e6efb33450944e6cbfddc1c2d56720f047ea2bf4afcb1d1228b9ea85efeedc56562ee8818ee78f12ac7e6cd91cfdb5949ac7fbb8a61a288fabd454b59fcb7b28e26bcd01e5b2bf80738515d8ab103ec8624bab1ec7964f4ddb122787354e12e7b7e228c9a303787a648ef2079a26d6f4d923bb20df5990b2b814e6ad5e2d4fe6d983651daba218260c7e89b3d2e7338efcc317f33e996faa7e64456170ceb0ce88aed190185232db121876f0cda68b39c5a2331ce37fee9c5cd012cd453cff00954be5cff969bcff00838bfea9e60ff2f66ee87fb2ff008a6ffc843be5f8f83bfe552f973fe5a6f3fe0e2ffaa78ff2f66ee87fb2ff008a5fc843be5f8f8327d6405d12f947416d28ff009267357a6fef63fd68ff00ba72b27d27dcf22f24798e5d0b525966afe8dbb3e95c75a0229471ef1f2dff00c86cebfb4b4633c287f790f547fe27fce751a6cdc12fe897b52b2b28652195855586e083dc6714453ba79df9d7ff00260e81feb5b7fd449ce8bb37fc4f2ff9ff00f4cdd76a7fbe8fc3fdd3d1739c762ec55e43e53f2ae9fe60d53544bc9268c5bbf24f44aad793b035e4afe19d7ebf5d3d3e381881eafe77c1d460c03248db276fcaad2631cacafeeede7de921646a54782ac67fe1b3583b7721faa3090f8ffc79cafc8c7a1284b4d7f5ef2beb51695afcff005cd3ee29e8deb12594134e5c8fc440ff00762b7d9fd9ff002adc9a4c5aac472611c138fd50fc7fb1611cb3c52e199e28ff00399379e3fe513d4bfe317fc6c3359d99fe310f7b93a9feecb0cf28fe5fe8dace870dfdd4d729348ceacb13205f858a8a06463dbc7375da1dad970e530888d6df55ff00c5387a7d24670b369d7fcaa5f2e7fcb4de7fc1c5ff0054f30bf97b37743fd97fc5377e421df2fc7c139f2df9474df2fb5c359493486e4207f5995a9c2b4a7154fe6cc2d67684f515c423e9fe6ff6b7e1d3c71dd7562da8ff00e4d9b4ff00553fe4cb66d70ffc67cbf1fc4e24ff00c607e3a3d1739c762ec55d8abb15762aec55d8abb157ffd7ee19e6ef46ec55d8abb15762ab65fee9ff00d53fab0c79a9e4f3cfc9ff00eeb55ff5a0fd526745ed07387f9dfef5d7767ff17c16fe60ff00ca67a1ff00cf1ff93e70f64ff8b64ff3bfdc2eaffbd8fe3aabe8e3f41fe63ded81f86d754532423a0e46b22fdc7d58c657a8fdfe8a33fe2c5b1ff73ff112658fd1988e924dff0032354fa979665894d25bd6102f8f13f13ffc28e3fecb313b1f071e707a43d5ff0012dbac9f0c3facc33ccba57e8bb6f2bda11c650a5e61dfd477466afc89e39b9d1e7f1659a5d3f87fab5270f34384403d7339176cf3cb46ff0010fe644971f6ecb480447e1ca3345fbe52ce3fd5ce8b20fcbe880fe3cdfefbfe39e975f1fde66be906ff0031209b4bd6b4cf325b2ee8e239bc094f8941ff005d39a7fb1c1d91219714f04bfcdfc7f464bab0632130cf6dae61b9b68ae616e50cc8b246de2ac2a33413818c8c4f38b9f1208b0f3af2effa6fe686a53cbbb5b35c70affc56c205ff008539d1eafd1a1801fc5c1fecbf78ebb0fab393dd7ff12f4ace69d92025f306830caf14ba95ac72c64abc6f3c6acac362082d5073223a4ca45884c8feac981cb01d47cd4b4993cae6e241a43591b865e528b431732a0f56f4f7a54f7c96719e8789e270ff00b6717fbe638ce3bf4f0ff9ac0bccfa9dbe97f99115fdc2bb4302233ac6016358caec0951dfc737fa2c072e88c07395ff00ba70334c473594f3fe56d7973fe59af3fe022ffaa9983fc839bbe1fecbfe25bff3f0ee97e3e2af61f99ba0df5f5bd9c505d2cb7322c485d230a19cd05692134caf2f62e5840c898544717f17fc4b286b6122051dd90eb7ff001c6bff00f9869bfe4d9cd7e9bfbd8ff5a3f7b9197e93ee79d7937cbf0eb9e4fd46d1a8b3adcf3b694fecc8235a7d0df65b3a2ed1d59c1a98cba70fabfabc4ebb4f884f191e69cfe5d79827224f2eea554beb2aac01fa945d8a7ce3edfe47fab987dafa41b6687d13fabfe2bfce6ed2653f44b9c507e75ffc983a07fad6dff51272eecdff0013cbfe7ffd3361a9fefa3f0ff74f45ce71d8bb1579d7e57ffc7635bff597fe26f9d1f6dff778ff001d22ebb45f549e8b9ce3b160df9b76c8da25a5c53f7915c8407fc991189fc51737bd833232ca3df1ff00727fe3ce0ebc7a41f3466ad70f73f96a67735792ca22e7c5a8b5fc729c10e1d6d0ff005497e96790de0bfe8b1df28fe6068da36870d85d4372f346ceccd12a15f898b0a16753dfc3363da1d939736533898d6df55ffc4b8fa7d5c610a369d7fcadaf2e7fcb35e7fc045ff55330bf907377c3fd97fc4b77e7e1dd2fc7c591797bcc165aed8b5e5a2491c4b2188894286e4a01fd96614f8b35dabd24b04f865575c5e97271651905861ba8ff00e4d9b4ff00553fe4cb66e70ffc67cbf1fc4e14ff00c607e3a3d1739c762ec55d8abb15762aec55d8abb157ffd0ee19e6ef46ec55d8abb15762ab65fee9ff00d53fab0c79a9e4f3cfc9ff00eeb55ff5a0fd526745ed07387f9dfef5d7767ff17c16fe60ff00ca67a1ff00cf1ff93e70f64ff8b64ff3bfdc2eaffbd8fe3aa37f32eda5b57d335fb71fbeb2982391e04f34afb72561fecf28ec698971e13ca71fc7e3fa2cf5a2aa63f850dae5c45e63f3a68fa7c279d95bc6b752f851c094834fe6411aff00b2cb74b03a6d36499fae4783fde7fbae26394f89962072fa96fe687fc76344ff0059bfe26987b13fbbc9f8e9246b7ea8b30f34eadfa2b41bbbd0692aa7187fe323fc2bf713cb34fa1c1e2e58c7a7f17f55cccf938204b01f28797bcee9a77d7f48bdb7b38afbe26130e5230424026b149b75a7c59bfed0d5e94cf832465330fe6fd3feee2e069f0e5e1b89038bf1dc98eb1e59fcc6d42c24b7bed46d2e60fb6615501894dc71220535ff006598da7d6e8b1cc18427197f3bf191b3261cd214483f8feaa3bf2bb59fade8cfa7c8d59ac1a8a0f5f49ea57fe05b92ff00c0e51db7a7e0cbc63964ff0074cf4592e35fcd4a2d19745fcd19d673c21bf67e0e7a1fac7c6bff0025470cccc83c6d00ae78ff00e9dfa7fdc3547d19cdff0017fbe7a5e732ec920baf227956eee65b9b8b1e73cee6495fd5985598d49a070333e1da9a8844444b68ff00463ff12d12d2e326c8627e43b7b7b6f3f6b16d6cbc6de18ee2389412d4559e30054924e6dfb52665a484a5f548c7fdc49c4d28032c80f3ff0074ada8ff00e4d9b4ff00553fe4cb6430ff00c67cbf1fc499ff008c0fc747a2e738ec5d8aa0b5bff8e35fff00cc34dff26ce5fa6fef63fd68fdec32fd27dcc4bf28ff00e38d79ff00313ff32d736ddbff00dec7fabfa5c4d07d27deb3f30b43b8b6b887ccfa6552e6d994dd71f01b2c94f6fb0ffe4ffb2c9764eaa3207064fa65f4ff00c4ff00c4a3578883e2479849353d72df5bf36796afa1a06636cb3c7fc920b93c97fa7f9399b874a7069f2c0ff4f87fabe1b4cf289e481f77fba7ac6726ed5d8abcebf2bffe3b1adffacbff00137ce8fb6ffbbc7f8e9175da2faa4f45ce71d8bcfbf362fd5e0b0d262f8ee2597d631aee760513fe08b37fc0e743d838a8cb21fa40e1ff007d275faf96c229d798accd97e5fcd667ed5bda47131f74e20feacc2d264e3d6097f3a665f7b7e68f0e1af26bf2d7fe511b6ff5e5ff0093871ed9ff00183fe6ff00b9468ffbb0ca3356e53b1579d6a3ff009366d3fd54ff00932d9d1e1ff8cf97e3f89d74ff00c607e3a3d1739c762ec55d8abb15762aec55d8abb157ffd1ee19e6ef46ec55d8abb15762ab6404a301d4820611cd4b0dfcb7f2f6b1a326a0352b7f40ce62317c68f5e3cebf619bf9866e7b63578f318f01e2e1e2eff2fe7387a3c5285f106bce1e5dd6751f336957b676feadb5b7a7eb49cd178f19791d99831f87c061ecfd663c7827191a94af879ff351a8c3294e240d8324f31696354d12f2c69579a33e957fdf8bf127fc3019add267f0b2c67dc7fd8ff13939a1c51218c7e5df95353d267bbbcd521f4ae1d1618017473c3ab6e85bf95066cfb5f5f0ca231c66e3f549c5d26094093254f3e797b58d5752d2e6b0b7f5a3b62c666e68bc6aca7a3b2d7a76c8f65eaf1e284c4cf0997d3cfcd96ab14a52040e4bbf30746f306b26cac74f83959ab7a97131745018fc2bf0b32b1e0bc8f4fdac1d93a8c3878a533ebfe11457578e73a006ccb2ced61b4b486d61148a0458e31fe4a8a0cd4e4999c8c8f393971880282b6412c134ff002d6bba479e26beb2b6f5348ba6612b878d6892fc47e12c1bf7727f93f6737d97598b36944647f7b1f297f0ff00c545c18619c32d81e929df9bfca36fe60b54e2e20be82bf579fb6fd55a9fb3ff0011cc1ecfd79d3cbf9d097d516ed469c641e691daebfe7dd1e316ba8e8d26a823f863b88492cc0742cc8b257fd92ab7f36674f4ba4cc78a19062fe8cbfe3dc0d11cb961b4a3c4a926ade7dd707d5acf4dfd0d6f27c32dd4e4fa8abd0f1e411bc7ecc7fec97223069307aa53f1a5fcd8fd3fefbfdd24e4cb3d80e06bca1e4fd4743f34de4aca64d38dbb4705d164abb3346d42a0f21d1bf670f68768433e088ff29c5ea87fa65d3e9e50c87f9b4a3e63d0bcd5fe325d6b49b24b858953d3323c61490854d54ba377c9e8f55a7fcb785925c37e52effeac919b164f138a22d15fa57f353feacd67ff0006bff65195781a0ff549fe3fe49b2e3d47f363f8ff0039dfa57f353feacd67ff0006bff6518f81a0ff00549fe3fe49af1ea3f9b1fc7f9cc9aea3bcb9d0a68a48c0bd9ad595a252282578c82a09247da3fcd9ab818c72820fa233ff0063c4e548130f3a48bf2eb43d5348d32e60d460f425927e68bc91eabc00ad50b0ea333fb5f538f34c181e2023f8fa9a3498a5089126552471cb1b4722878dc157461504114208cd50241b0e5116f315fcbdd66c3cd96d3d9c1eae950dd4332cdea202b1890310559831283c07c59d39ed6c7934e448d6430946a8fd54eb3f2928e4047d36f50ce5dd9bb1579968fa479ff43bebd9ec34c865176db99a48cec18914e32a7f377ce9f51a8d2678444e64707f344bfe224eb31e3cd02481cff1de9b35efe6adc0f4c585a59d6bfbe0c869b781965ff886620c7a08efc539ff0047f10837716a0f403f1ef44f97fc8d2dbea3fa635bbafafea75e494a98d18746ab00588fd9f855532ad5f698943c3c43c3c7fec9962d2d4b8a478a49cf9aac6eafbcbd7d696a9ea5c4d1f18d2a16a7903d5881987a1cb1c79a3296d105bb3c4ca040e6c3f438ff0032b46d3a3b0b5d26d9e18cb32b4b2216f88f2352b3a8efe19b8d49d166999ca72bfe883ff54dc3c433c234223f1fe7261fa57f353feacd67ff0006bff65198fe0683fd527f8ff926d9c7a8fe6c7f1fe726be5dbcf394f752aebb6105a5b84ac4f0b024bd46c692c9dbdb313598f4d188f0a529cbfa5ff4841bb0cb213eb000fc79a41e63d0bcd5fe325d6b49b24b858953d3323c61490854d54ba377cd868f55a7fcb785925c37e52eff00eac9c7cd8b2789c51168afd2bf9a9ff566b3ff00835ffb28cabc0d07faa4ff001ff24d971ea3f9b1fc7f9c9a7976f7ceb3deba6b96105ada08c949216058c9c968bb4b26dc797ece62eaf1e9631bc5294e57fc5fcdff004906dc32ca4fac003f1e6c8735ce43b15762aec55d8abb157fffd2ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd3ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd4ee19e6ef46ec55d8abb15762aec55d8abceec7cebe78d4eeeea0d334fb4b8faab10f5aa103910bf6e65af4ed9d165ecdd2e288392538f17e3f98ebe3a9cb224440dbf1fce471d5ff0034d4166d1ad0a8dc80ca4d0785273947e5f41fea93fc7fc9367e267fe68fc7f9c8bf2d79e46a5a8be95a85a1b0d492bc632490c5772bb8055b8eff00e5653aceccf0e1e2425e263678753c478643864bfcf7e68d4340b6b496ce38a469dd95c4c19800a01db8b260ecbd0c351290913e9fe6aeab39c605201357fcd3750cba3d99560083c97a1ffa38cc83a7d00ff293fc7fc9361e267fe6c7f1fe7295d79a3f30f4d88dcea3a2c06d5013218892401dc95925e23e6b92868b4790f0c324b8bfa5ff0048c112cf9a3bca22bf1e6c9bcb7e62b3d7b4e1776e0c6ea784d031a947eb4af707f65b359acd1cb04f84ff009b27270e619058446b3acd8e8f60f7b78fc634d9546ecec7a2a8f1395e9b4f3cd3e18f365932080b2c3ed75bf3ff0098ab3e93143a6d8124453cc01240f7657e5fec63e39b89e9b49a7db219659ff363f88ffbb70e393364de3e98aebad43f323418cdd5f0b7d56cd3799a200145ff0062b130ff005b83ae0861d1673c30e2c52e9c5f89ff00ba594f363dcd4c328f2f7986c35db11756848653c6685bed46d4e87dbf95bf6b357abd24f04f865fe6cbf9ce5e2cc262c247e73f36eb3a3ea76563a74304cd76bb098313ccbf10010e807d399dd9da0c79b1ca73321c1fcdff00a464e3ea33ca120235ba97e95fcd4ffab359ff00c1affd9464fc0d07faa4ff001ff24d1c7a8fe6c7f1fe72d87f30ef2cae63b7f31e972587a9f66e12a53a0df891b81fe4bb619764c671270cc64fe8a8d5989a98e16690cd14f124d0b8922900647535041dc104669251313479b9a0dee18bddf9af5187cf10682b1c26ce50a5a42adea6f196d8f2e3d47f2e6d71e82074a72dcb887fa5fa9c596790cbc1d195e6a5ca4a7cd7ab5ce91a05d6a36ca8f341e9f059012a79c8a86a14a9e8de3997a1d3c73661097295ff00b96acf90c20486fcafaadc6ada0daea170a8934e1cbac60851c5d945012c7a2f8e0d6e018b2ca11e51fd4b82667004a55e68f3bfe8dbb5d2f4c83ebdab4941e90a9542454060bbb31fe51997a2ecdf123e2643e1e26acfa9e13c311c5240ad9fe6b4c9eb9beb5b62457eaa5509141d2a23906fff001932f393b3e26b8672fe96ff00f151ff0072d7c3a83bd81f8f72ed37cefaa58ea8ba4f9a2d96da590810dda6c86a680b6e4713fcebf67f697066ecdc73c7e2603c407d50fe24c35328cb8720a4ebcc977e6cb76b7fd03650dd860ff58331038914e34ac9175f8b30b478f4f2bf1a5287f3787fe919b7e696415c02d8e6a5e67fcc7d36cdef2f74bb38ada3a0792bca9c8851b2cecdd4e6cb0e8b45925c319ccc8fe3fd4dc69e7cd116446bf1fd25d61e64fccabfb48ef2d34ab396de604c6f50b500d3a34e0f51832e8f458e46329cc487e3fd4d619b3c8588c6bf1fd2649e5bbaf33cf1ce75eb386d1d4afa02120f206bcab4925f6cd6eb218224783233fe7717fd2307270cb21be31480f3579da2d2675d3ac61faeead2d02c22a550b7d9e5c7e22cdd9172fd0f669ca38e678310fe26bcfa9e03c23d524bd2d7f356e93d7fae5ad8f21b5bb2a123fe49cbff0013cc833d0436e19cff00a5f8943fdcb588ea0ef622b60f3b6b9a3ea11d8f9aad1638e4feeef611b53c7625587f371e2cbfcb865d9b8b340cf4f2b23f824a353281ac83fce6728e8e8ae8c19180656535041dc104668c820d173816f02bb15762aec55d8abb15762aff00ffd5ee19e6ef46ec55d8abb15762aec55d8abcebf2bffe3b1adffacbff00137ce8fb6ffbbc7f8e9175da2faa4f45ce71d8bcd3cd7c5bf32f4b169bce0db7afc7af21212797fcf2e3fec73a6d0ff88cf8b97af87fd2ff00c5badcff00df8af245fe6f7fbc3a77fc6593fe22329f67feb9fb832ed0e419ddaffbcd0ffa8bfab3433fa8b9f1e4ddccb6f15bcb25c32ac08a4cacdf64281bd7e8c61124811fa964401bbcf7f292297d5d5674056d58c68b5eec0b1ff8553ff0d9d0f6fc85407f16ff00a1d7e80733d1679d1db5af3b69fa11622da2282551e327c6e7fe4585a64bb34783a5965fe23fef7d31ff00668d4faf288747a3451470c49144a1238c05445140140a000673729126cf3764052f2010411507a8c0af34d2d7fc3df993269f07c1637bf088c740b22f34007f90ff0000ff00273a6ce7f31a2133f5c3fdefa65fec5d6c3f779a87292b7e60ff00ca5da0ff00ad1ffc9e190ec9ff0017c9f1ff00709d5ff791fc757a2e738ec52df316910eada3dcd948a199d0984f75900aa30fa732749a838b2090f8ff0055af36313890c5ff0029f53927d2aeac2462df53915a2af6496a683fd92b1ff659b4edec223904c7f18ff70e2e8277123b909a8ffe4d9b4ff553fe4cb65d87fe33e5f8fe2613ff00181f8e8f45ce71d8b1bfcc5ff943b50ff9e3ff0027d3365d91fe331ff3bfdc49c7d5ff00767f1d54fc9972b6be43b6b961558219e523d92476fe192ed18716acc7f9d28c7ec8a34f2ac40fbd22fcaeb3fae5dea3ae5d7ef2e99f8239de8cf5790efe355199fdb7938230c51da3f8e171f451b26679bd1739c76290f9bbca91798ad6088cff005696072eb370f50f1228cb4e49d4f13d7f6733fb3f5e74f226b88487d37c2d1a8c1e201d137b1825b7b282de593d69218d6379a94e65401ca9534e5d7ae61e5909489038412dd11400483f31ff00e50fbdff005a2ff93ab9b0ec7ff198ff009dfee4b8facfeecabf90ff00e511d3bfd46ff938d90ed4ff00189fe3f859697fbb09cde5ca5ad9cf74ff006208de56f922963fab30b1c0ca4223f88f0b74a540979ffe59599d4350d475fbca49745f846c7b34956723c362aa3fc9ce83b6b278708e18ed1ff89fa5d7e8a3c44ccf37a36738ec524f3969116a9e5ebb85941962469addbb8923048a7fadf67fd96677676a0e2cd13d0fa65fd5934ea31f140a53f95faa4977e5f6b694966b290c684ffbed87251f41e4332bb6f00866e21fc63fd934e8a770afe6b31cd3b98ec55d8abb15762aec55d8abffd6ee19e6ef46ec55d8abb15762aec55d8abc87ca76be679f54d50683790da3abfefccc01e40bb71a56397df3afd7cf0471c3c6899ff3787e1fd283a8c11c864780d3283a3fe68bfc126b56aa8db332280c077a5205ff008966aff31a01cb1cff001ff251caf0f3ff00387e3fcd47796bc8d069578da95e5cb5fea6f53eb3d68a5bed11525998ff00331ca359da672c78223c3c7fcd67874c227889e2924ff9bdfef0e9dff1964ff888cccf67feb9fb834f68720af0f917cc4d0c6c3cd576a19410a04bb5474fefb212ed3c209fdcc3fd8ffd536434b3afae5f8ff398ff009a7cbfaee94619f56bdb8d5f48e603fef9d58126b460fea05e54ea3361a1d5e2cb631c63872ff547fbde071f3e29c3791338bd1fcbaba40d1ad9b48411d83af289475dfaf2ad4f3aecd9cdeace4f14f89f5bb2c3c3c2387e960f7d5b6fcdc865936599a3e07c795bfa43fe1866f317abb3881fc37feef8dc196da8fc7f35e959cd3b2762af35d66971f9ab651c5bb44d0f3a7f90a643ff000b9d2e9fd3a0913d78bfe25d6e4df50157f307fe52ed07fd68ff00e4f0c8f64ff8be4f8ffb84eaff00bc8fe3abd1739c762b26952185e590d12352ee7c028a9c31892687552685bceff286272faacf4a21f4947857e327eece8fb7e5b407f5bfdebaed00e6576a429f9b1664ec0aa53fe4530c187fe33e5f8fe259ff008c07a2e738ec58dfe62ffca1da87fcf1ff0093e99b2ec8ff00198ff9dfee24e3eaff00bb3f8ea83f2f44d2fe591897ed496774aa3dd8c8065dab956baffa70ff007ad7885e0ff36484fca3950e8d7b103f1adcf223d99140ff00889cb7b7e3fbd89fe8fe963a03e93ef6779a2739d8abb15633f98fff00287deffad17fc9d5cd9f63ff008cc7fceff725c6d67f7655fc87ff00288e9dfea37fc9c6c876a7f8c4ff001fc2cb4bfdd84c35f89e6d0b5185055e4b599147bb46c06636964065813d271ff74d9945c08f2627f947321d1ef611f6d2e3991ece8a07fc40e6dfb7e3fbc89fe8fe9713407d27decef342e7213569521d2af2573448e091989f0084e5b8224e4881fce0c721a89f730bfca289c69fa84a7ec3cc880fbaad4ffc4866efb7e5eb88f270b40362cff39f73dd8abb15762aec55d8abb157ffd7ee19e6ef46ec55d8abb15762aec55d8abcebf2bffe3b1adffacbff00137ce8fb6ffbbc7f8e9175da2faa4f45ce71d8bb1579ff00e6f7fbc3a77fc6593fe2233a0f67feb9fb83afed0e419ddaff00bcd0ff00a8bfab3433fa8b9f1e487d6b4d4d4b49bab07a52e2364527a06eaadfec5a872cd36638f24663f84b1c90e2890c3bf2ab527fab5ee8f3d565b57f5110f50ac78b8ff62e3fe1f373dbb84714720e5315ff0012e1e867b189e88cfcc2f2d5ddf4706ada6a93a8d8efc57edb229e438f8b46df128ca7b275b18138e7fdde4fc7fb267abc265ea8fd5144797bf30746bfb644bf992c6fd0526498f042c3a9566f8687f958f2caf57d93971cae03c487f0f0b2c3ab8c86fe992b6b7e7ef2f69d6ccd0dcc77b734fdd41030704ff94eb5551e390d376566c92dc1847f9d24e4d5422363c4529f21681a8497d71e65d594add5df236f1b0a101f767a7ec8a7c283f97fd8e65f6aeaa0203063fa61f57fc4ff00c53569711b33973281fcc89a283cd1a2cf29e314411e46a134559aa4d06fd32fec789960c80733ff0012d7ac359225927fcac5f277fd5c3fe48cff00f3466b7f92353fcdff00650ff8a72bf378fbfef4835ef3acdafc0fa37972d669a4b91c269caf1011ba81fca0f4677e39b0d2f668d39f17318c787e98fe3fdeb8f9752720e180e6ca7ca5e5e5d0b478ed090f70e4c972e3a19180141fe4a81c7355afd5f8f90cbf87947faae569f17046bab18fcc1b5bbd3b5dd3bccb6f1992180a25c01d8a31239780756e15cda764ce39314b013465f4fe3fa2e2eae2633130c9ec7ce5e58bc81664d4608aa2a639dd62707c08723f0cd5e5ececf0346323fd51c6e54751022ed8b79f3cd167aadb47a168cc6f6e6e655f50c5bad14d4283d1896a1dbe1cdaf65e8a58a472e5f44623f89c5d567131c11f512cd342d37f4768d6760c4334112a484742d4ab53db9139a5d566f132ca7fce2e6e2870c40602a2e7c89e65965789a4d0af8d03a0ad054951e1ce3a9dbf69337e7875d800bacd8ff1fe966ebf7c13fe8499b43e6ef2c4d0899753b6084568f22a3f4afd8621ff000cd1cb419c1ae097c9ce1a881176184f9bf5aff15dfda687a183711a49ea4b3d084e54e3cb7fd840cd56fdafd9ff002b79d9fa6fca425972fa4d7d3f8fe29383a8c9e291083d1ac2d23b3b2b7b48ff00bbb78d2253d2a1140afe19ce65c8672323fc4789d9463c200483f31ffe50fbdff5a2ff0093ab99fd8ffe331ff3bfdc971f59fdd957f21ffca23a77fa8dff00271b21da9fe313fc7f0b2d2ff7613fcd7b7bcce68aefc8de6492f12169741be346e1fb209a85f678cfd8afdb4ff85e9a328ebb0089359a1f8ff65fee9d690704eff824cd2dbcdfe58b8804c9a9dba29fd996458dc6d5fb0e55b34b3ecfcf134612ff00347139a351022ec314f36f9b0eb80797fcbcad7525c902e275042f106bc549a6dfceff00678e6db41a0f03f7d9bd1c3f4c7f1fec62e267cfc7e886f6cbfcb5a1c7a2e8f058290eeb569a41d1a46dd8fcbb2ff939a7d66a4e6c867fe97faae5e1c5c11a4d3315b5d8abb15762aec55d8abb157fffd0ee19e6ef46ec55d8abb15762aec55d8aa1ad74dd3ad1dded6d61b7797fbc68a3542ddfe22a057ae593cd398024652afe7163184472089cad93b1543de69da7deaaade5b4572a86a8264590027c39034cb31e69c3e9263fd53c2c65012e62d5c000000500d80195b26f1542c3a5e9905cbdd43690c573257d49d234591b91ab5580e46a7ae5b2cf394784ca463fcdbf4b110883606e8aca99253a97953cbba94864bcb18e495b76916b1b9f9b21563997875d9b18a8c8d7fa6ff74d53c109730b2c3c9de59b0904b6da7c62406aaefca520fb190b53e8c965ed0cf9054a46bfd2ff00b94434f08f209ce6137216f34ad2ef5d5ef2ce0b97514569a349081d680b0396e3cf921b46528ff54f0b19638cb98050ff00e1af2e7fd5aacffe91e2ff009a72cfce66fe7cff00d3498f830fe6c7e48e82dedede3f4e089228c7ec22851e1d065129991b26d98007254c8a56c91a488c92287461465615041ec41c20906c2916914fe42f28cf2191f4e40c7b46f246be3f65195733e3daba888a13ff00732ff741a0e9719e88fd33cbda2e97bd859c703d286402af4f0e6d56fc731f3eaf2e5fae464ce18a31e4130cc76c539e082e2268678d6589c51e3750ca47b83b64a3331360d15201d8a452fe5ff942472eda72827a8592541b6df655c0ccf8f6b6a40ae2fb23fa9c73a4c67a26fa7e97a769d118ac6da3b74635611a8153ee7a9fa730f2e79e4373264dd08463c8522b2a64a5736b6d750b41730a4f0b539452287534351556a8eb9284e513713c27c906208a2ddbdbdbdbc2b0dbc490c29b2471a8551df602806339991b26ca8000a0a9914ac9a186689a29916489c51e3701948f020ed86323136362a403cd229bc81e509a42efa72863d91e541ff028cab99f1ed5d4015c7f647f538e74b8cf44d34ed234bd350a58dac76e1bed145009f99ea7e9cc5cda8c990dcc9937431c63c852332964ec55d8abb15762aec55d8abb157fffd1ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd2ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd9, 365, 1);
INSERT INTO `producto` (`id_pro`, `id_cat`, `id_mar`, `id_mod`, `ser_pro`, `des_pro`, `pco_pro`, `pve_pro`, `img_pro`, `gar_pro`, `act_pro`) VALUES
(25, 19, 7, 4, '2022120108211', 'Computadora HP más vieja', '100.00', '90.00', 0xffd8ffe000104a46494600010101012b012b0000ffee000e41646f626500640000000001ffe10be44578696600004d4d002a000000080007011200030000000100010000011a00050000000100000062011b0005000000010000006a012800030000000100020000013100020000001f000000720132000200000014000000928769000400000001000000a6000000c6012bfff400010000012bfff40001000041646f62652050686f746f73686f702032322e32202857696e646f7773290000323032323a31313a32322031373a34323a3530000002a0020004000000010000015ea0030004000000010000015e0000000000000006010300030000000100060000011a00050000000100000114011b0005000000010000011c012800030000000100020000020100040000000100000124020200040000000100000ab80000000000000048000000010000004800000001ffd8ffed000c41646f62655f434d0001ffee000e41646f626500648000000001ffdb0084000c08080809080c09090c110b0a0b11150f0c0c0f1518131315131318110c0c0c0c0c0c110c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c010d0b0b0d0e0d100e0e10140e0e0e14140e0e0e0e14110c0c0c0c0c11110c0c0c0c0c0c110c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0cffc00011080054005403012200021101031101ffdd00040006ffc4013f0000010501010101010100000000000000030001020405060708090a0b0100010501010101010100000000000000010002030405060708090a0b1000010401030204020507060805030c33010002110304211231054151611322718132061491a1b14223241552c16233347282d14307259253f0e1f163733516a2b283264493546445c2a3743617d255e265f2b384c3d375e3f3462794a485b495c4d4e4f4a5b5c5d5e5f55666768696a6b6c6d6e6f637475767778797a7b7c7d7e7f711000202010204040304050607070605350100021103213112044151617122130532819114a1b14223c152d1f0332462e1728292435315637334f1250616a2b283072635c2d2449354a317644555367465e2f2b384c3d375e3f34694a485b495c4d4e4f4a5b5c5d5e5f55666768696a6b6c6d6e6f62737475767778797a7b7c7ffda000c03010002110311003f00ee12496767f5fe9d817fd9ed2f7dc002f656dddb6756ef712d6ee77ee2e6218e790f0c226477a8ba529088b91a74542db6aa2a7dd738575560b9ef3c001647fcede95fb97ff983ff0026b1bae75a77527b6aa43abc3ac8706bb473dffe92d03f73fc157ff5cff8bb38790cd3981389c71fd291ede1fd6629e7801713c45dbff9d7d23fe1bfedb3fde97fcebe91e377fdb67fbd72092d0ff4672ffd7ff187fdeb07de32787d8f7181d73a7750b8d18ef70b40dc1963769701f4b67ef6d57d79cb1efadedb2b71658c21cc7b796b870e0ba8c6fadd886867daebb1b911167a4d05848fcf64bdbf4ff73f3154e6be1d28107083389de3bca27fef59717300d89d0f1779258bff003b7a57ee5ffe60ff00c9ad6c6c9a32a866463bc5955825ae12383b4820fb9ae6bbe93553c9832e300ce12883a590cd1c91969120a44924944b9fffd0ee170bd55a5fd6f2980c17e46c04f6dc58c9fc5774b87ea3ff002fddff0086d9ff00555ac6f85ff3993fb9ff007516df33b47cdb591d0fa5e35cea323abb2ab591b98eae0891b87e7feea87ecae8bff97757f99ff99a87d64ff9772bfeb7ff0050c598afe18659e384ce79dce3191a8e1fd28f17f9b6bc8c412384686b793adfb2ba2ffe5dd5fe67fe6697ecae8bff0097757f99ff0099ac94949ed64ff3f3ff00170ffeaa47147f747db274f2fa3e2d5d3eccfc4cf6e65753db5bc359025c5ad8ddb9dee6ef6b957c5e95d4b32a3762e3badac12dde0b4091f487e91ec5731fff001299bff86ebfcb420f4d6e19a1c6feab6f4f7979fd0d7be0881167b0ed76e51c726410c9eae3943270094a0727a78612f9397e0fde5c446e3a5031bd0ffdfb532b0f2b0ed1565d469b0b7706920cb4e9ba585cdecba9faa9ff00247fd7acff00beae6ba88a0648f4331f9ed2c137581db8193fa2fd27d2fde5d2fd54ff00923febd67fdf543f1024f291277328dfa650fdefd09fae2bf057bba762ec24924b15b8ff00ffd1ee170fd47fe5fbbff0db3feaab5dc2e1fa8ffe282eff00c36cff00aaad637c2ff9cc9fdcff00ba8b6f99da3e6cfeb27fcbb97ff5bffa862cd5b7d7fa6f51bface4db4e2db6d4ed9b5ed6c830c6b4ff00d259ff00b23abffdc2bbfcdff6ad1e5f2e3183103388231c3f4a3fb8d79c4f14b43b9e8d4495bfd91d5ffee15dfe6ffb52fd91d5ff00ee15dfe6ff00b54bef62ff00390ff1a2b7865d8fd8dcc7ff00c4a66ffe1baff2d0aa74fe939fd4771c5ac1630c3ac7bb6b67f701f76e77f655ff00b2e4e37d56cc664d4fa5eec9adc1af104b6686ee50c5761f50e88ce956e5b306ea2d75b36ff37635c5eed7dd5eed9ea7d1dffe0d55190c63965020839e8ce8e58c21c10f5f0e3f9d90c6cc41fdcdbe5bd767372b13270ef763e530d76b4031c820fd17b1c3e931753f553fe48ffaf59ff7d587d77331f22dc6a31ec390cc3a7d27649ff08ef6cbb77e7edd9f4ff96b73eaa7fc91ff005eb3fefaa3e7a529727194c70c8ca3636fdee92fde5d80019686a28bb092492c66e3ffd2ee170fd7e8ba8ead92eb1a5adb9fead2f830e0437563ff00798e5dc2a79dd42dc5f51b553eb3d9536d63376ddce75a31c57f45dfbcb9fe4b34b164b8c44f8870f093c1b9fde6f678094459aa3dade3bf6cf54ffb9d7ff9e52fdb1d53fee75dfe715d97ed461caf4c47d98639c97e44f11b1fb3647fa0b7d5728b3a8defa580d21996fb7d0f44ba5ad7167da43acb037e8fd97f4bed6ff39fa1573ef83ff1247bfcd0dbbff36c3ed7fac3f6178ffdb1d53fee75dfe714bf6c754ffb9d77f9c575d6753b6a86bcd1b8dde89b7d4fd181e9d974bdaddf6d566eabd1f4acff003d48f5335d98adb363eac80fdf7d4e258cdaeae9a9dee1eeadf65cdaec7ff827ff00c1a5f7b1a7f4581bdbd51edc5fe6ff00e6a3daff005874f02f177751cdc867a791956db5c83b1ee2448fa26103737c577c73adfb236f6b00b1f70a431c4c026efb2ee7383777f2d0eeea76d2f14dadaabb7d46b0bdcf3e96c7b2db596eed9bfe963be9f4d3a1cf91623cb8144d88e488f97e6fd051c23acffe6bc2ee6f8aed3ead63dd474960b986b758f7d8d6b843b6b8fb3737f37746e5728cc7596d75cb1e2cadf6fa953896fb1ecab6b770ff008456156e739d96580c671f06bc5f371fcb71fdd8b2e1c2232e2e2be9b52924925419dfffd3ee102ec3aaeb3d5717076d63742222bb1b94dedfe919fe623aa9d4aa75d5d0c0c6d9fac564b5ed2e640ddad8d6fe62e631df10a3c3e2e8cf6dad63d2317696cbf638d9b84882db5f55afa4fb7f99db8d5e3b19ff0071bf469dfd3715af75acfd58cb1c0d7b58d6bd85fe9dcd6edd9ea39973e97eefe7a9fd1aabfb35cdcaa5bb297b5debd9b5d517515ee18cc6d75d7bbd9bbd3f53e97bff0058f628e3575d5f6739b5c50caed6b5b6309aebbfd577acd6b36bb652eaff0047d3dfff00717f47fe17f493d488046532bfd1afef74fd2fe698f4d8c29b87a6fe9bd7f5ed191b9aef50060d58db6a6b457e9fa7b7664d9f9a8bf646b9cd7dee75e4576547d40d8732d2c2f6bd95b18dff0005b56663d38cdb47db71dcea4d4f18ec7d4fb1cdacdf73e9a9a031efa9ff0067757b6afe76b67a7fb8a4c36e3d16b7303fd7bb06a60905ee7d8d6dec7d5b99bfd4bdbead7b92942566a5645463e900ca3f27eaebf4611f994243f777f16eb702aaf0eac26daf02b735f5bcb83ac2e63fd7066c6bbd5f7fd3f6247a7b770b45d67ae2c167afec2e2431f4359b4d7e8fa4daad7fb1b57fc22a62ac7ac5f5e6d2eb2f3e98a035a5d6398daea6d6cc3b9bfcdba9c86dbf42dafd1b3f58b3e9fa88b66101999b66352c65e719871ed0c022e272fdecb36ff39eeafd4ffa681045dccfabd56623867c7c1c5eafddf5fa95a7ee8d34dff75b0ec473ec6d9f6ab3d6a9aeadcf02a261e5b66d7b3d22cf6ecf6fb1595998edc537e1fd86a351a83864fb0b0b6b2c70f4725ce037dcec9f45fefdf67f3972d3516504100f6eb110947d457c35bd14924928d7bfffd4ee125f3924b9574dfa353899d2657ce2924a7e8ed7fbd213da7cd7ce2924a7e8e130638ee997ce4924a7e8e3302663b265f3924929fa3525f3924929ffd9ffe202404943435f50524f46494c450001010000023041444245021000006d6e74725247422058595a2007cf00060003000000000000616373704150504c000000006e6f6e65000000000000000000000000000000000000f6d6000100000000d32d4144424500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a63707274000000fc0000003264657363000001300000006b777470740000019c00000014626b7074000001b00000001472545243000001c40000000e67545243000001d40000000e62545243000001e40000000e7258595a000001f4000000146758595a00000208000000146258595a0000021c000000147465787400000000436f7079726967687420313939392041646f62652053797374656d7320496e636f72706f726174656400000064657363000000000000001141646f62652052474220283139393829000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000058595a20000000000000f35100010000000116cc58595a200000000000000000000000000000000063757276000000000000000102330000637572760000000000000001023300006375727600000000000000010233000058595a200000000000009c1800004fa5000004fc58595a20000000000000348d0000a02c00000f9558595a2000000000000026310000102f0000be9cffdb0043000604040405040605050609060506090b080606080b0c0a0a0b0a0a0c100c0c0c0c0c0c100c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0cffdb0043010707070d0c0d18101018140e0e0e14140e0e0e0e14110c0c0c0c0c11110c0c0c0c0c0c110c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0cffc0001108015e015e03011100021101031101ffc4001f0000000701010101010000000000000000040503020601000708090a0bffc400b51000020103030204020607030402060273010203110400052112314151061361227181143291a10715b14223c152d1e1331662f0247282f12543345392a2b26373c235442793a3b33617546474c3d2e2082683090a181984944546a4b456d355281af2e3f3c4d4e4f465758595a5b5c5d5e5f566768696a6b6c6d6e6f637475767778797a7b7c7d7e7f738485868788898a8b8c8d8e8f82939495969798999a9b9c9d9e9f92a3a4a5a6a7a8a9aaabacadaeafaffc4001f0100020203010101010100000000000000010002030405060708090a0bffc400b5110002020102030505040506040803036d0100021103042112314105511361220671819132a1b1f014c1d1e1234215526272f1332434438216925325a263b2c20773d235e2448317549308090a18192636451a2764745537f2a3b3c32829d3e3f38494a4b4c4d4e4f465758595a5b5c5d5e5f5465666768696a6b6c6d6e6f6475767778797a7b7c7d7e7f738485868788898a8b8c8d8e8f839495969798999a9b9c9d9e9f92a3a4a5a6a7a8a9aaabacadaeafaffdd0004002cffda000c03010002110311003f00ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd0ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd1ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1540eafade99a45b7d62fe611464d106e598f82a8dce5fa7d34f34b8602d864cb180b290ff00cacff2affbf26ff914733ff91351dd1f9b8ff9dc6eff00959fe55ff7e4dff228e3fc89a8ee8fcd7f3b8ddff2b3fcabfefc9bfe451c7f91351dd1f9afe771bbfe567f957fdf937fc8a38ff226a3ba3f35fcee377fcacff2affbf26ff91471fe44d47747e6bf9dc6eff959fe55ff007e4dff00228e3fc89a8ee8fcd7f3b8ddff002b3fcabfefc9bfe451c7f91351dd1f9afe771bbfe567f957fdf937fc8a38ff00226a3ba3f35fcee377fcacff002aff00bf26ff0091471fe44d47747e6bf9dc6e1f99de5424032ca2bdcc469f863fc8ba8ee1f35fcee364d67796b7b6c9736b2acd0482a922ee08cd664c72848c642a41ca8c8485856c825d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762afffd2ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8aa1356d56cf4bb096f6edf84310fa58f6551dd8e5d8304b2cc463ccb1c9311165e21e63f305e6b9a8b5ddc1e283e182107e18d3b01eff00cc73b8d1e923821c23fce97f39d1e6ca672b295665353b15762aec55d8abb15762aec55d8abb15651e48f384ba1ddfa1704be993b7ef53a98dba7a8bff001b0fdacd5f697678cf1b1fde47fd97f45cad36a380d1fa5ec914b14d124b13078a40191d4d41077041ce325120d1e6ee41b5f815d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157fffd3ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec554aeaeaded2da4b9b871141129691dba003270819c84622c944a400b2f15f3879aee35fbfa8ac7610922da13ff00136ff29bfe173b5ecfd08d3c3fa72faa4e97519ce43fd163f9b071dd8abb15762aec55d8abb15762aec55d8abb15762acdff002ffcea74e9574bd41ffd024348656ff7531ec7fe2b6ff85cd1f6b766f883c487d63eafe9ff00c79ced26a787d27e97ac0208a8e99c9bb5762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55fffd4ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762ad3ba2233b90a8a09663b0007524e102f60af1ff003df9c9f59b936566c46990b6c46deab8fdb3fe4ff20ff659d8765f677831e297f792ff0060e9f55a8e3343e96239b7711d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abd27f2efced5f4f45d4a4df65b29d8fdd131ff887fc0ff2e735dafd9bcf2c07f5e3feff00fe29d969353fc32ff35e8d9ce3b1762aec55d8abb15762aec55d8abb15762aec55d8abb15762afffd5ee19e6ef46ec55d8abb15762aec552ad47cd3e5ed39cc7797d1c728eb1825dc7cd5031199787439b20b8c4d354f3c23cca5fff002b17ca1ff2dc7fe454bff34e5ffc91a9fe6ffb28feb6bfcde3ef77fcac5f287fcb71ff009152ff00cd38ff00246a7f9bfeca3fad7f398fbddff2b17ca1ff002dc7fe454bff0034e3fc91a9fe6ffb28feb5fce63ef77fcac5f287fcb71ff9152ffcd38ff246a7f9bfeca3fad7f398fbddff002b17ca1ff2dc7fe454bff34e3fc91a9fe6ff00b28feb5fce63ef77fcac5f287fcb71ff009152ff00cd38ff00246a7f9bfeca3fad7f398fbd87f9efcf91ea51fe8ed2a43f52600dc4d42a64ff00200343c07ed7f366e7b2fb2ce33c7907aff863fcd70f55aae2f4c79305cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8ab60904106847438abd3bca9f99363fa3c5beb9318ee60a2a5c7167f517b72e20fc63bff3672fafec6971de217197f0ff0035d9e0d60aa9f34eff00e562f943fe5b8ffc8a97fe69cc1fe48d4ff37fd947f5b7fe731f7bbfe562f943fe5b8ffc8a97fe69c7f92353fcdff651fd6bf9cc7deeff00958be50ff96e3ff22a5ff9a71fe48d4ff37fd947f5afe731f7bbfe562f943fe5b8ff00c8a97fe69c7f92353fcdff00651fd6bf9cc7deeff958be50ff0096e3ff0022a5ff009a71fe48d4ff0037fd947f5afe731f7b63f317ca04d3ebdff24a5ff9a71fe48d4ff37fd947f5afe6f1f7a6da6ebba3ea40fd46ee39c8ea8adf10f9a9a37e19899b4b9317d71316e8658cb9147650cdd8abb15762aec55d8abfffd6ee19e6ef46ec55d8abb15762af36fcc1f3c5c25c49a3e97218c47f0dddc21a316ef1a9ed4fda39d2f64f6602064c82ff00991ff7ceb757a937c3179d1249a9dc9ea73a375cd62aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec555209e682559a0768a5435491090c0fb119194448511612091b87adf907ce4facc2d657a47e91817907e9eaa74e54fe65fdace47b57b3bc13c51feee5fec1dbe9751c628fd4cc334ee5bb15762aec55d8abfffd7ee19e6ef46ec55d8abb15436a5726d34ebaba1d60864947fb052dfc32cc30e3988ff003a422c672a892f9ee491e491a47259dc96663d4926a4e7a18000a0f3c4dadc2aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb154e3ca1752db799f4c78cd0bdc47137bacadc1bf06cc3ed080960983fcd32ff004bea6ed3caa63def77ce0ddebb15762aec55d8abffd0ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8aa65e5aff948f4aff98cb7ff0093ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157fffd1ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762af59f2f7e5be849a6412ea311babb9915deaccaabc8578a8523a789ce4b57db194cc881e18876d8b470e1f56e534ff00957be51ff9601ff2324ff9ab317f95b51fcefb22dbf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff957be51ff009601ff002324ff009ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff957be51ff009601ff002324ff009ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff957be51ff009601ff002324ff009ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff957be51ff009601ff002324ff009ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f725dae7e5ae812e9f2b69f11b5bb8d4b44c1d9958815e2c189d8fb66469bb673098e33c716bcba3811b6c5e479d7ba8762aec55d8abb15762aec55d8abb15762a99796bfe523d2bfe632dff00e4eae636b3fb99ff00525fee5b30fd71feb07bee700efdd8abb15762aec55fffd2ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f2091f997cefa7e817915adcc134af2c7ea868f8d29c8ad3e223f9733747d9b3d444ca240a3c3bb466d48c66884a3fe56de89ff002c773ff24ffe6acccfe40cbfce8ffb2fd4d3f9f8f7177fcadbd13fe58ee7fe49ff00cd58ff002065fe747fd97ea5fcfc7b8bbfe56de89ff2c773ff0024ff00e6ac7f9032ff003a3fecbf52fe7e3dc5dff2b6f44ff963b9ff00927ff3563fc8197f9d1ff65fa97f3f1ee2eff95b7a27fcb1dcff00c93ff9ab1fe40cbfce8ffb2fd4bf9f8f7177fcadbd13fe58ee7fe49ffcd58ff2065fe747fd97ea5fcfc7b8bbfe56de89ff002c773ff24ffe6ac7f9032ff3a3fecbf52fe7e3dc5dff002b6f44ff00963b9ff927ff003563fc8197f9d1ff0065fa97f3f1ee2eff0095b7a27fcb1dcffc93ff009ab1fe40cbfce8ff00b2fd4bf9f8f7177fcadbd13fe58ee7fe49ff00cd58ff002065fe747fd97ea5fcfc7b8bbfe56de89ff2c773ff0024ff00e6ac7f9032ff003a3fecbf52fe7e3dc5dff2b6f44ff963b9ff00927ff3563fc8197f9d1ff65fa97f3f1ee2eff95b7a27fcb1dcff00c93ff9ab1fe40cbfce8ffb2fd4bf9f8f7177fcadbd13fe58ee7fe49ffcd58ff2065fe747fd97ea5fcfc7b8bbfe56de89ff002c773ff24ffe6ac7f9032ff3a3fecbf52fe7e3dc5dff002b6f44ff00963b9ff927ff003563fc8197f9d1ff0065fa97f3f1ee29b796fcf5a76bd7cf676d6f344e91994b49c694040a7c24ff0036626b3b327821c52313bf0b6e1d50c86806433ff7127faa7f566be3cc392793e743d4e7a33ce358aa71e58f2ddd6bfa8fd561711468bce7988a855ad3a7727b661eb7591d3c388ee7f862dd8709c92a0ce47e516994defe6af7f853345fcbf3fe6c5cefc847bdbff9545a5ffcb7cfff000298ff002fe4fe6c57f211ef77fcaa2d2ffe5be7ff00814c7f97f27f362bf908f7a035afcaafab584b71a7ddb4d2c4a5cc12281c80152148fdacc8d376ef14c4671e107f89af26868582f3cce85d7bb15762a99796bfe523d2bfe632dffe4eae636b3fb99ff525fee5b30fd71feb07bee700efdd8abb15762aec55ffd3ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358ab26f22799adf42d4e47ba526d2e5024aca2a5483556a771e39aced4d11cf01c3f545c9d2e618e5bf22f4b1e7bf29115fd229bf8abffcd39ccff25ea3f987ec767f9ac7deeff1df94bfeae51ffc0bff00cd38ff0025ea3f987ec5fcd63ef77f8efca5ff005728ff00e05ffe69c7f92f51fcc3f62fe6b1f7a5fae7e63797edf4f97ea571f5bbb752b0c68ac0062280b16005066469bb2334a63887045af2eb2006c6cbc7b3b174eec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd4ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15762aec55d8abb15762aec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd5ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358ab22f24f96135fd4de299cc76b6ebea4c57ed1a9a0515e95f1cd77696b4e9e163ea97d2e469b0f892df93d147e5af9440ff00795cfbfab27f5ce73f96751dff00ec62ec7f278fb9dff2adbca3ff002cafff002364ff009ab1fe59d47f3bfd8c57f278fb9dff002adbca3ff2caff00f2364ff9ab1fe59d47f3bfd8c57f278fb901adfe58e88f612b69aaf6f771a968eaeceac40af160d5ebed991a6edaca2638fd516193451af4f3793e758ea5d8abb154cbcb5ff291e95ff3196fff00275731b59fdccffa92ff0072d987eb8ff583df738077eec55d8abb15762aff00ffd6ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358aa79e52f334be5fd48dc08fd68255e13c55a12b5a820ff32e60ebf443510e1ba90fa5bf066f0e56cf87e6c797a82b05c83e1c53fe6bcd07f20e6ef87dbfa9cffcfc3b8bbfe56c7977fdf173ff00009ff35e3fc859bbe1f6ff00c4afe7a1e6eff95b1e5dff007c5cff00c027fcd78ff2166ef87dbff12bf9e879a035afcd5b392c25874cb7945c4aa504b2f1509514e4002d53e197e9bb0a4260cc8e11fcd6bc9ae045446ef34ce99d6bb15762a99796bfe523d2bfe632dffe4eae636b3fb99ff525fee5b30fd71feb07bee700efdd8abb15762aec55ffd7ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15762aec55d8abb15762aec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd0ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15762aec55d8abb15762aec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd1ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15762aec55d8abb15762aec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd2ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15657e5bfcbcd5b578d6e67616566dba48e2aee3c5536dbfca6cd4eb3b5f1e13c23d7372f0e9253dcfa433183f2a7cb88804b2dc4afddb9aafe01734f2eddcc4ec221cc1a1879a0353fca4b46466d32f1e393b47380ca7db928047fc0b65f87b7e57eb8edfd16b9e807f0979feada3ea3a4ddb5adf4262946ebdd587f329e84674383510cb1e281b0ebf26330345059730762aec5532f2d7fca47a57fcc65bff00c9d5cc6d67f733fea4bfdcb661fae3fd60f7dce01dfbb15762aec55d8abfffd3ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358ab2ff00cbaf2c47ab6a2f77769cacace84a1e8f21dd54ff00923ed3669fb5f5a7143863f5cffd8c5ccd261e3959e517b00000a0d80ce3ddbb1cbffcc0f2bd94e607ba32c8a68fe8a97507fd61f0fdd9b1c5d959e62c0afeb38f3d5e389ab4d749d734bd5a03369f70b32aece0543293fcca68c33173e9b2623531c2db8f2c662c14379a3cbb6dae69725b48009d416b69bba3f6ff0062dd1b2dd16ae5832090fa7f8831cf844e34f0a9a192199e19578c91b14753d4329a119ddc64242c722e888ad966143b154cbcb5ff00291e95ff003196ff00f275731b59fdccff00a92ff72d987eb8ff00583df738077eec55d8abb15762afffd4ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abd93f2cadd22f2a42ea3e29e491dcfb86e1fa9738deda993a823f9a03b9d10ac6dfe646a97161e5b616ec524ba91602e3a856059a9f30bc70763e019336ffc038975933186dd5e359d9ba64e7ca1aadc69be60b396262164916199074649182907efa8cc2ed0c03261903d07147fcd6ed3ccc661eed9c23bd788f9fedd20f36dfaa6c1d924a7bba2b1fc4e76fd95332d3c6ff1bba4d50ac858f66c5c7762a99796bfe523d2bfe632dffe4eae636b3fb99ff525fee5b30fd71feb07bee700efdd8abb15762aec55ffd5ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abd6bf2ab518e7d064b2afef6d253f0ff009127c40ffc172ce47b73098e612e931fee5db686770aee4f7cd7a08d6f4596c83049aa2481cf4122f4afb1fb3983a1d5781944ba7f17f55bf3e2e38d3c56ff0046d534fb8682eed648a4069ba9a1f7523661f2cedb16a31e417120874b3c7289a2194f90bc99a85cea506a57b0b41656cc2441202ad23aeeb4077e20ee5b355da9da308c0c2278a72dbfaae56974c4cb88f20f59ce49db3c1fcdba8a6a3e63beba8cf289a4e31b78ac60203f4f1cef34184e3c3189e75fee9d1679f14c94a3331a5d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd6ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358aa6de59f30dc685aa25e4439c6470b886b4e687a8f98eab989add2473e3e13cff0085b70e53095bdb349d634fd5ad16eac6512c6df687ed29fe561fb27388cfa79e2970cc517778f2098b08dca59bb1560be7df3cdbda5b4ba5e9b2092f250527990d444a762011feec3ff0b9bdecaecc3390c931e81f4ff4ff00e3ae0eab5200e18f37956756ea9d8abb154cbcb5ff00291e95ff003196ff00f275731b59fdccff00a92ff72d987eb8ff00583df738077eec55d8abb15762afffd7ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f2086d4340d1b519566beb48ee2545e0aee2a42d49a7e39662d565c62a12310c678a32dc842ff00833cadff0056c83fe072dfe51cff00cf930fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee08ad3fcbfa2e9d319ec6ce3b79994a174143c49048fc32acbabcb9054a464194314626c0464ffdc49feab7eaca63cc361e4f9d4f539e8cf38d62aec551361a8dfd84e27b29dede51fb4848a8f03e3f4e57970c320a90e20ca3331360b2387f33bcd51a056921948fda78c57fe14a8cd6cbb174e4f223e2e48d6e4416a7e79f336a28639af0c7136c638408c11ee57e23f7e5f87b33063362367fa5ea6b9ea672e6520ccf68762aec55d8aa65e5aff948f4aff98cb7ff0093ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157fffd0ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762acef41fcd1b8b0b08acef6d3eb5e82848e657e0c546c03020d683be68755d88324cca32e1e2fe173f16b4c45116997fcadfb5ffab649ff002347fcd398dfe87e5fcf1fe95b3f940773bfe56fdaff00d5b24ff91a3fe69c7fd0fcbf9e3fd2aff280ee77fcadfb5ffab649ff002347fcd38ffa1f97f3c7fa55fe501dceff0095bf6bff0056c93fe468ff009a71ff0043f2fe78ff004abfca03b9dff2b7ed7fead927fc8d1ff34e3fe87e5fcf1fe957f940773bfe56fdaffd5b24ff0091a3fe69c7fd0fcbf9e3fd2aff00280ee77fcadfb5ff00ab649ff2347fcd38ff00a1f97f3c7fa55fe501dceff95bf6bff56c93fe468ff9a71ff43f2fe78ff4abfca03b9dff002b7ed7fead927fc8d1ff0034e3fe87e5fcf1fe957f940773bfe56fdaff00d5b24ff91a3fe69c7fd0fcbf9e3fd2aff280ee77fcadfb5ffab649ff002347fcd38ffa1f97f3c7fa55fe501dceff0095bf6bff0056c93fe468ff009a71ff0043f2fe78ff004abfca03b9dff2b7ed7fead927fc8d1ff34e3fe87e5fcf1fe957f940773bfe56fdaffd5b24ff0091a3fe69c7fd0fcbf9e3fd2aff00280ee77fcadfb5ff00ab649ff2347fcd38ff00a1f97f3c7fa55fe501dceff95bf6bff56c93fe468ff9a71ff43f2fe78ff4abfca03b9dff002b7ed7fead927fc8d1ff0034e3fe87e5fcf1fe957f940773bfe56fdaff00d5b24ff91a3fe69c7fd0fcbf9e3fd2aff280ee4bf5bfcd49ef2c64b5b1b4fab3cca51e777e4429d8f1000dfdf3234dd86213129cb8abf85af26b891405302cdfb80ec55d8abb15762aec55d8abb15762aec5532f2d7fca47a57fcc65bffc9d5cc6d67f733fea4bfdcb661fae3fd60f7dce01dfbb15762aec55d8abffd1ee19e6ef46ec55d8abb154bbcc5ff28fea7ff3093ffc9b6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8aa65e5aff948f4aff98cb7ff0093ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157fffd2ee19e6ef46ec55d8abb1552bab74b9b59addfec4c8d1b7c98107f5e4a13e19090fe12890b14f9f6feca7b1bd9ad275e3340e51c7b83d7e9cf42c5904e2243949e7e51313450f9631762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8ab20f226992dff99ec8203c2d9c5ccadd8088861f7b715cd7f6a6618f04aff8bd1fe99c8d2c38a63c9edf9c3bbb762aec55d8abb157ffd3ee19e6ef46ec55d8abb15762ac47cede464d6ffd36ccac5a922d0f2d96551d031ecc3f65b36fd9bda6707a65be3ff70e26a74dc7b8fa9e55a868faa69d298ef6d6481877653c4fc9bec9fa33abc3a8c7905c4893aa9e39479841e5cc1d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8aa6ba3f95f5bd5a554b4b573193f14ee0ac6bf363fc331351adc5887a8ff009bfc4db8f04a7c83d7fca9e56b4f2fd898a33eadd4b4373714a7223a01e0abdb390d76ba5a89d9da23e98bb8c180631e69de60b73b15762aec55d8abffd4ee19e6ef46ec55d8abb15762aec55a6556146008f03be20aa9fd56dbfdf29ff02325c72ef470877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0870b6b61d224ff008118f1cbbd7842af4c8a5d8abb15762aec55d8abb157ffd5ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1542ddeaba5d9b05bbbc82dd8f412c8884ff00c11196e3c1927f4c652fea86329c473202eb4d42c2f056d2e62b803a989d5c7fc293832629c3ea063fd60b1983c8da232b64ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55ffd6ee19e6ef46ec55d8abb15762ab65fee9ff00d53fab0c79a9e4f3cfc9ff00eeb55ff5a0fd526745ed07387f9dfef5d7767ff17c107f9a90493f9874e82315925855107bb4ac065dd87211c3227a4bfdeb0d70b980c8bf2c753375e5efaa39fded8486320f5e0df12feb65ff00639aeedac3c39b8872c81c9d14ee15fcd6593cd1c10493ca78c7129776f05515273531899100732e59342de0f2cd7379ab26a930a0bcbb623e619588f9287519de4631863f0c7f043f1fee5d0924cb88ff00117bde702ef985fe676a7247a5dbe936fbdcea5205e23a945236ff0064e5066ebb1708390e43f4e31f8ff62e1eb67e9111ce480fcbe9a7d1f5dd43cb576d56afa901dc02ca0569febc7c5bfd8e6476b4466c51cf1feacbf1fd1935e90984cc0bd0f39d760c2bcf3e68d421ba8341d1891a8dd15124abf69039a2aa9eccdd4b7ec2e6efb33450944e6cbfddc1c2d56720f047ea2bf4afcb1d1228b9ea85efeedc56562ee8818ee78f12ac7e6cd91cfdb5949ac7fbb8a61a288fabd454b59fcb7b28e26bcd01e5b2bf80738515d8ab103ec8624bab1ec7964f4ddb122787354e12e7b7e228c9a303787a648ef2079a26d6f4d923bb20df5990b2b814e6ad5e2d4fe6d983651daba218260c7e89b3d2e7338efcc317f33e996faa7e64456170ceb0ce88aed190185232db121876f0cda68b39c5a2331ce37fee9c5cd012cd453cff00954be5cff969bcff00838bfea9e60ff2f66ee87fb2ff008a6ffc843be5f8f83bfe552f973fe5a6f3fe0e2ffaa78ff2f66ee87fb2ff008a5fc843be5f8f8327d6405d12f947416d28ff009267357a6fef63fd68ff00ba72b27d27dcf22f24798e5d0b525966afe8dbb3e95c75a0229471ef1f2dff00c86cebfb4b4633c287f790f547fe27fce751a6cdc12fe897b52b2b28652195855586e083dc6714453ba79df9d7ff00260e81feb5b7fd449ce8bb37fc4f2ff9ff00f4cdd76a7fbe8fc3fdd3d1739c762ec55e43e53f2ae9fe60d53544bc9268c5bbf24f44aad793b035e4afe19d7ebf5d3d3e381881eafe77c1d460c03248db276fcaad2631cacafeeede7de921646a54782ac67fe1b3583b7721faa3090f8ffc79cafc8c7a1284b4d7f5ef2beb51695afcff005cd3ee29e8deb12594134e5c8fc440ff00762b7d9fd9ff002adc9a4c5aac472611c138fd50fc7fb1611cb3c52e199e28ff00399379e3fe513d4bfe317fc6c3359d99fe310f7b93a9feecb0cf28fe5fe8dace870dfdd4d729348ceacb13205f858a8a06463dbc7375da1dad970e530888d6df55ff00c5387a7d24670b369d7fcaa5f2e7fcb4de7fc1c5ff0054f30bf97b37743fd97fc5377e421df2fc7c139f2df9474df2fb5c359493486e4207f5995a9c2b4a7154fe6cc2d67684f515c423e9fe6ff6b7e1d3c71dd7562da8ff00e4d9b4ff00553fe4cb66d70ffc67cbf1fc4e24ff00c607e3a3d1739c762ec55d8abb15762aec55d8abb157ffd7ee19e6ef46ec55d8abb15762ab65fee9ff00d53fab0c79a9e4f3cfc9ff00eeb55ff5a0fd526745ed07387f9dfef5d7767ff17c16fe60ff00ca67a1ff00cf1ff93e70f64ff8b64ff3bfdc2eaffbd8fe3aabe8e3f41fe63ded81f86d754532423a0e46b22fdc7d58c657a8fdfe8a33fe2c5b1ff73ff112658fd1988e924dff0032354fa979665894d25bd6102f8f13f13ffc28e3fecb313b1f071e707a43d5ff0012dbac9f0c3facc33ccba57e8bb6f2bda11c650a5e61dfd477466afc89e39b9d1e7f1659a5d3f87fab5270f34384403d7339176cf3cb46ff0010fe644971f6ecb480447e1ca3345fbe52ce3fd5ce8b20fcbe880fe3cdfefbfe39e975f1fde66be906ff0031209b4bd6b4cf325b2ee8e239bc094f8941ff005d39a7fb1c1d91219714f04bfcdfc7f464bab0632130cf6dae61b9b68ae616e50cc8b246de2ac2a33413818c8c4f38b9f1208b0f3af2effa6fe686a53cbbb5b35c70affc56c205ff008539d1eafd1a1801fc5c1fecbf78ebb0fab393dd7ff12f4ace69d92025f306830caf14ba95ac72c64abc6f3c6acac362082d5073223a4ca45884c8feac981cb01d47cd4b4993cae6e241a43591b865e528b431732a0f56f4f7a54f7c96719e8789e270ff00b6717fbe638ce3bf4f0ff9ac0bccfa9dbe97f99115fdc2bb4302233ac6016358caec0951dfc737fa2c072e88c07395ff00ba70334c473594f3fe56d7973fe59af3fe022ffaa9983fc839bbe1fecbfe25bff3f0ee97e3e2af61f99ba0df5f5bd9c505d2cb7322c485d230a19cd05692134caf2f62e5840c898544717f17fc4b286b6122051dd90eb7ff001c6bff00f9869bfe4d9cd7e9bfbd8ff5a3f7b9197e93ee79d7937cbf0eb9e4fd46d1a8b3adcf3b694fecc8235a7d0df65b3a2ed1d59c1a98cba70fabfabc4ebb4f884f191e69cfe5d79827224f2eea554beb2aac01fa945d8a7ce3edfe47fab987dafa41b6687d13fabfe2bfce6ed2653f44b9c507e75ffc983a07fad6dff51272eecdff0013cbfe7ffd3361a9fefa3f0ff74f45ce71d8bb1579d7e57ffc7635bff597fe26f9d1f6dff778ff001d22ebb45f549e8b9ce3b160df9b76c8da25a5c53f7915c8407fc991189fc51737bd833232ca3df1ff00727fe3ce0ebc7a41f3466ad70f73f96a67735792ca22e7c5a8b5fc729c10e1d6d0ff005497e96790de0bfe8b1df28fe6068da36870d85d4372f346ceccd12a15f898b0a16753dfc3363da1d939736533898d6df55ffc4b8fa7d5c610a369d7fcadaf2e7fcb35e7fc045ff55330bf907377c3fd97fc4b77e7e1dd2fc7c591797bcc165aed8b5e5a2491c4b2188894286e4a01fd96614f8b35dabd24b04f865575c5e97271651905861ba8ff00e4d9b4ff00553fe4cb66e70ffc67cbf1fc4e14ff00c607e3a3d1739c762ec55d8abb15762aec55d8abb157ffd0ee19e6ef46ec55d8abb15762ab65fee9ff00d53fab0c79a9e4f3cfc9ff00eeb55ff5a0fd526745ed07387f9dfef5d7767ff17c16fe60ff00ca67a1ff00cf1ff93e70f64ff8b64ff3bfdc2eaffbd8fe3aa37f32eda5b57d335fb71fbeb2982391e04f34afb72561fecf28ec698971e13ca71fc7e3fa2cf5a2aa63f850dae5c45e63f3a68fa7c279d95bc6b752f851c094834fe6411aff00b2cb74b03a6d36499fae4783fde7fbae26394f89962072fa96fe687fc76344ff0059bfe26987b13fbbc9f8e9246b7ea8b30f34eadfa2b41bbbd0692aa7187fe323fc2bf713cb34fa1c1e2e58c7a7f17f55cccf938204b01f28797bcee9a77d7f48bdb7b38afbe26130e5230424026b149b75a7c59bfed0d5e94cf832465330fe6fd3feee2e069f0e5e1b89038bf1dc98eb1e59fcc6d42c24b7bed46d2e60fb6615501894dc71220535ff006598da7d6e8b1cc18427197f3bf191b3261cd214483f8feaa3bf2bb59fade8cfa7c8d59ac1a8a0f5f49ea57fe05b92ff00c0e51db7a7e0cbc63964ff0074cf4592e35fcd4a2d19745fcd19d673c21bf67e0e7a1fac7c6bff0025470cccc83c6d00ae78ff00e9dfa7fdc3547d19cdff0017fbe7a5e732ec920baf227956eee65b9b8b1e73cee6495fd5985598d49a070333e1da9a8844444b68ff00463ff12d12d2e326c8627e43b7b7b6f3f6b16d6cbc6de18ee2389412d4559e30054924e6dfb52665a484a5f548c7fdc49c4d28032c80f3ff0074ada8ff00e4d9b4ff00553fe4cb6430ff00c67cbf1fc499ff008c0fc747a2e738ec5d8aa0b5bff8e35fff00cc34dff26ce5fa6fef63fd68fdec32fd27dcc4bf28ff00e38d79ff00313ff32d736ddbff00dec7fabfa5c4d07d27deb3f30b43b8b6b887ccfa6552e6d994dd71f01b2c94f6fb0ffe4ffb2c9764eaa3207064fa65f4ff00c4ff00c4a3578883e2479849353d72df5bf36796afa1a06636cb3c7fc920b93c97fa7f9399b874a7069f2c0ff4f87fabe1b4cf289e481f77fba7ac6726ed5d8abcebf2bffe3b1adffacbff00137ce8fb6ffbbc7f8e9175da2faa4f45ce71d8bcfbf362fd5e0b0d262f8ee2597d631aee760513fe08b37fc0e743d838a8cb21fa40e1ff007d275faf96c229d798accd97e5fcd667ed5bda47131f74e20feacc2d264e3d6097f3a665f7b7e68f0e1af26bf2d7fe511b6ff5e5ff0093871ed9ff00183fe6ff00b9468ffbb0ca3356e53b1579d6a3ff009366d3fd54ff00932d9d1e1ff8cf97e3f89d74ff00c607e3a3d1739c762ec55d8abb15762aec55d8abb157ffd1ee19e6ef46ec55d8abb15762ab6404a301d4820611cd4b0dfcb7f2f6b1a326a0352b7f40ce62317c68f5e3cebf619bf9866e7b63578f318f01e2e1e2eff2fe7387a3c5285f106bce1e5dd6751f336957b676feadb5b7a7eb49cd178f19791d99831f87c061ecfd663c7827191a94af879ff351a8c3294e240d8324f31696354d12f2c69579a33e957fdf8bf127fc3019add267f0b2c67dc7fd8ff13939a1c51218c7e5df95353d267bbbcd521f4ae1d1618017473c3ab6e85bf95066cfb5f5f0ca231c66e3f549c5d26094093254f3e797b58d5752d2e6b0b7f5a3b62c666e68bc6aca7a3b2d7a76c8f65eaf1e284c4cf0997d3cfcd96ab14a52040e4bbf30746f306b26cac74f83959ab7a97131745018fc2bf0b32b1e0bc8f4fdac1d93a8c3878a533ebfe11457578e73a006ccb2ced61b4b486d61148a0458e31fe4a8a0cd4e4999c8c8f393971880282b6412c134ff002d6bba479e26beb2b6f5348ba6612b878d6892fc47e12c1bf7727f93f6737d97598b36944647f7b1f297f0ff00c545c18619c32d81e929df9bfca36fe60b54e2e20be82bf579fb6fd55a9fb3ff0011cc1ecfd79d3cbf9d097d516ed469c641e691daebfe7dd1e316ba8e8d26a823f863b88492cc0742cc8b257fd92ab7f36674f4ba4cc78a19062fe8cbfe3dc0d11cb961b4a3c4a926ade7dd707d5acf4dfd0d6f27c32dd4e4fa8abd0f1e411bc7ecc7fec97223069307aa53f1a5fcd8fd3fefbfdd24e4cb3d80e06bca1e4fd4743f34de4aca64d38dbb4705d164abb3346d42a0f21d1bf670f68768433e088ff29c5ea87fa65d3e9e50c87f9b4a3e63d0bcd5fe325d6b49b24b858953d3323c61490854d54ba377c9e8f55a7fcb785925c37e52effeac919b164f138a22d15fa57f353feacd67ff0006bff65195781a0ff549fe3fe49b2e3d47f363f8ff0039dfa57f353feacd67ff0006bff6518f81a0ff00549fe3fe49af1ea3f9b1fc7f9cc9aea3bcb9d0a68a48c0bd9ad595a252282578c82a09247da3fcd9ab818c72820fa233ff0063c4e548130f3a48bf2eb43d5348d32e60d460f425927e68bc91eabc00ad50b0ea333fb5f538f34c181e2023f8fa9a3498a5089126552471cb1b4722878dc157461504114208cd50241b0e5116f315fcbdd66c3cd96d3d9c1eae950dd4332cdea202b1890310559831283c07c59d39ed6c7934e448d6430946a8fd54eb3f2928e4047d36f50ce5dd9bb1579968fa479ff43bebd9ec34c865176db99a48cec18914e32a7f377ce9f51a8d2678444e64707f344bfe224eb31e3cd02481cff1de9b35efe6adc0f4c585a59d6bfbe0c869b781965ff886620c7a08efc539ff0047f10837716a0f403f1ef44f97fc8d2dbea3fa635bbafafea75e494a98d18746ab00588fd9f855532ad5f698943c3c43c3c7fec9962d2d4b8a478a49cf9aac6eafbcbd7d696a9ea5c4d1f18d2a16a7903d5881987a1cb1c79a3296d105bb3c4ca040e6c3f438ff0032b46d3a3b0b5d26d9e18cb32b4b2216f88f2352b3a8efe19b8d49d166999ca72bfe883ff54dc3c433c234223f1fe7261fa57f353feacd67ff0006bff65198fe0683fd527f8ff926d9c7a8fe6c7f1fe726be5dbcf394f752aebb6105a5b84ac4f0b024bd46c692c9dbdb313598f4d188f0a529cbfa5ff4841bb0cb213eb000fc79a41e63d0bcd5fe325d6b49b24b858953d3323c61490854d54ba377cd868f55a7fcb785925c37e52eff00eac9c7cd8b2789c51168afd2bf9a9ff566b3ff00835ffb28cabc0d07faa4ff001ff24d971ea3f9b1fc7f9c9a7976f7ceb3deba6b96105ada08c949216058c9c968bb4b26dc797ece62eaf1e9631bc5294e57fc5fcdff004906dc32ca4fac003f1e6c8735ce43b15762aec55d8abb157fffd2ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd3ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd4ee19e6ef46ec55d8abb15762aec55d8abceec7cebe78d4eeeea0d334fb4b8faab10f5aa103910bf6e65af4ed9d165ecdd2e288392538f17e3f98ebe3a9cb224440dbf1fce471d5ff0034d4166d1ad0a8dc80ca4d0785273947e5f41fea93fc7fc9367e267fe68fc7f9c8bf2d79e46a5a8be95a85a1b0d492bc632490c5772bb8055b8eff00e5653aceccf0e1e2425e263678753c478643864bfcf7e68d4340b6b496ce38a469dd95c4c19800a01db8b260ecbd0c351290913e9fe6aeab39c605201357fcd3750cba3d99560083c97a1ffa38cc83a7d00ff293fc7fc9361e267fe6c7f1fe7295d79a3f30f4d88dcea3a2c06d5013218892401dc95925e23e6b92868b4790f0c324b8bfa5ff0048c112cf9a3bca22bf1e6c9bcb7e62b3d7b4e1776e0c6ea784d031a947eb4af707f65b359acd1cb04f84ff009b27270e619058446b3acd8e8f60f7b78fc634d9546ecec7a2a8f1395e9b4f3cd3e18f365932080b2c3ed75bf3ff0098ab3e93143a6d8124453cc01240f7657e5fec63e39b89e9b49a7db219659ff363f88ffbb70e393364de3e98aebad43f323418cdd5f0b7d56cd3799a200145ff0062b130ff005b83ae0861d1673c30e2c52e9c5f89ff00ba594f363dcd4c328f2f7986c35db11756848653c6685bed46d4e87dbf95bf6b357abd24f04f865fe6cbf9ce5e2cc262c247e73f36eb3a3ea76563a74304cd76bb098313ccbf10010e807d399dd9da0c79b1ca73321c1fcdff00a464e3ea33ca120235ba97e95fcd4ffab359ff00c1affd9464fc0d07faa4ff001ff24d1c7a8fe6c7f1fe72d87f30ef2cae63b7f31e972587a9f66e12a53a0df891b81fe4bb619764c671270cc64fe8a8d5989a98e16690cd14f124d0b8922900647535041dc104669251313479b9a0dee18bddf9af5187cf10682b1c26ce50a5a42adea6f196d8f2e3d47f2e6d71e82074a72dcb887fa5fa9c596790cbc1d195e6a5ca4a7cd7ab5ce91a05d6a36ca8f341e9f059012a79c8a86a14a9e8de3997a1d3c73661097295ff00b96acf90c20486fcafaadc6ada0daea170a8934e1cbac60851c5d945012c7a2f8e0d6e018b2ca11e51fd4b82667004a55e68f3bfe8dbb5d2f4c83ebdab4941e90a9542454060bbb31fe51997a2ecdf123e2643e1e26acfa9e13c311c5240ad9fe6b4c9eb9beb5b62457eaa5509141d2a23906fff001932f393b3e26b8672fe96ff00f151ff0072d7c3a83bd81f8f72ed37cefaa58ea8ba4f9a2d96da590810dda6c86a680b6e4713fcebf67f697066ecdc73c7e2603c407d50fe24c35328cb8720a4ebcc977e6cb76b7fd03650dd860ff58331038914e34ac9175f8b30b478f4f2bf1a5287f3787fe919b7e696415c02d8e6a5e67fcc7d36cdef2f74bb38ada3a0792bca9c8851b2cecdd4e6cb0e8b45925c319ccc8fe3fd4dc69e7cd116446bf1fd25d61e64fccabfb48ef2d34ab396de604c6f50b500d3a34e0f51832e8f458e46329cc487e3fd4d619b3c8588c6bf1fd2649e5bbaf33cf1ce75eb386d1d4afa02120f206bcab4925f6cd6eb218224783233fe7717fd2307270cb21be31480f3579da2d2675d3ac61faeead2d02c22a550b7d9e5c7e22cdd9172fd0f669ca38e678310fe26bcfa9e03c23d524bd2d7f356e93d7fae5ad8f21b5bb2a123fe49cbff0013cc833d0436e19cff00a5f8943fdcb588ea0ef622b60f3b6b9a3ea11d8f9aad1638e4feeef611b53c7625587f371e2cbfcb865d9b8b340cf4f2b23f824a353281ac83fce6728e8e8ae8c19180656535041dc104668c820d173816f02bb15762aec55d8abb15762aff00ffd5ee19e6ef46ec55d8abb15762aec55d8abcebf2bffe3b1adffacbff00137ce8fb6ffbbc7f8e9175da2faa4f45ce71d8bcd3cd7c5bf32f4b169bce0db7afc7af21212797fcf2e3fec73a6d0ff88cf8b97af87fd2ff00c5badcff00df8af245fe6f7fbc3a77fc6593fe22329f67feb9fb832ed0e419ddaffbcd0ffa8bfab3433fa8b9f1e4ddccb6f15bcb25c32ac08a4cacdf64281bd7e8c61124811fa964401bbcf7f292297d5d5674056d58c68b5eec0b1ff8553ff0d9d0f6fc85407f16ff00a1d7e80733d1679d1db5af3b69fa11622da2282551e327c6e7fe4585a64bb34783a5965fe23fef7d31ff00668d4faf288747a3451470c49144a1238c05445140140a000673729126cf3764052f2010411507a8c0af34d2d7fc3df993269f07c1637bf088c740b22f34007f90ff0000ff00273a6ce7f31a2133f5c3fdefa65fec5d6c3f779a87292b7e60ff00ca5da0ff00ad1ffc9e190ec9ff0017c9f1ff00709d5ff791fc757a2e738ec52df316910eada3dcd948a199d0984f75900aa30fa732749a838b2090f8ff0055af36313890c5ff0029f53927d2aeac2462df53915a2af6496a683fd92b1ff659b4edec223904c7f18ff70e2e8277123b909a8ffe4d9b4ff553fe4cb65d87fe33e5f8fe2613ff00181f8e8f45ce71d8b1bfcc5ff943b50ff9e3ff0027d3365d91fe331ff3bfdc49c7d5ff00767f1d54fc9972b6be43b6b961558219e523d92476fe192ed18716acc7f9d28c7ec8a34f2ac40fbd22fcaeb3fae5dea3ae5d7ef2e99f8239de8cf5790efe355199fdb7938230c51da3f8e171f451b26679bd1739c76290f9bbca91798ad6088cff005696072eb370f50f1228cb4e49d4f13d7f6733fb3f5e74f226b88487d37c2d1a8c1e201d137b1825b7b282de593d69218d6379a94e65401ca9534e5d7ae61e5909489038412dd11400483f31ff00e50fbdff005a2ff93ab9b0ec7ff198ff009dfee4b8facfeecabf90ff00e511d3bfd46ff938d90ed4ff00189fe3f859697fbb09cde5ca5ad9cf74ff006208de56f922963fab30b1c0ca4223f88f0b74a540979ffe59599d4350d475fbca49745f846c7b34956723c362aa3fc9ce83b6b278708e18ed1ff89fa5d7e8a3c44ccf37a36738ec524f3969116a9e5ebb85941962469addbb8923048a7fadf67fd96677676a0e2cd13d0fa65fd5934ea31f140a53f95faa4977e5f6b694966b290c684ffbed87251f41e4332bb6f00866e21fc63fd934e8a770afe6b31cd3b98ec55d8abb15762aec55d8abffd6ee19e6ef46ec55d8abb15762aec55d8abc87ca76be679f54d50683790da3abfefccc01e40bb71a56397df3afd7cf0471c3c6899ff3787e1fd283a8c11c864780d3283a3fe68bfc126b56aa8db332280c077a5205ff008966aff31a01cb1cff001ff251caf0f3ff00387e3fcd47796bc8d069578da95e5cb5fea6f53eb3d68a5bed11525998ff00331ca359da672c78223c3c7fcd67874c227889e2924ff9bdfef0e9dff1964ff888cccf67feb9fb834f68720af0f917cc4d0c6c3cd576a19410a04bb5474fefb212ed3c209fdcc3fd8ffd536434b3afae5f8ff398ff009a7cbfaee94619f56bdb8d5f48e603fef9d58126b460fea05e54ea3361a1d5e2cb631c63872ff547fbde071f3e29c3791338bd1fcbaba40d1ad9b48411d83af289475dfaf2ad4f3aecd9cdeace4f14f89f5bb2c3c3c2387e960f7d5b6fcdc865936599a3e07c795bfa43fe1866f317abb3881fc37feef8dc196da8fc7f35e959cd3b2762af35d66971f9ab651c5bb44d0f3a7f90a643ff000b9d2e9fd3a0913d78bfe25d6e4df50157f307fe52ed07fd68ff00e4f0c8f64ff8be4f8ffb84eaff00bc8fe3abd1739c762b26952185e590d12352ee7c028a9c31892687552685bceff286272faacf4a21f4947857e327eece8fb7e5b407f5bfdebaed00e6576a429f9b1664ec0aa53fe4530c187fe33e5f8fe259ff008c07a2e738ec58dfe62ffca1da87fcf1ff0093e99b2ec8ff00198ff9dfee24e3eaff00bb3f8ea83f2f44d2fe591897ed496774aa3dd8c8065dab956baffa70ff007ad7885e0ff36484fca3950e8d7b103f1adcf223d99140ff00889cb7b7e3fbd89fe8fe963a03e93ef6779a2739d8abb15633f98fff00287deffad17fc9d5cd9f63ff008cc7fceff725c6d67f7655fc87ff00288e9dfea37fc9c6c876a7f8c4ff001fc2cb4bfdd84c35f89e6d0b5185055e4b599147bb46c06636964065813d271ff74d9945c08f2627f947321d1ef611f6d2e3991ece8a07fc40e6dfb7e3fbc89fe8fe9713407d27decef342e7213569521d2af2573448e091989f0084e5b8224e4881fce0c721a89f730bfca289c69fa84a7ec3cc880fbaad4ffc4866efb7e5eb88f270b40362cff39f73dd8abb15762aec55d8abb157ffd7ee19e6ef46ec55d8abb15762aec55d8abcebf2bffe3b1adffacbff00137ce8fb6ffbbc7f8e9175da2faa4f45ce71d8bb1579ff00e6f7fbc3a77fc6593fe2233a0f67feb9fb83afed0e419ddaff00bcd0ff00a8bfab3433fa8b9f1e487d6b4d4d4b49bab07a52e2364527a06eaadfec5a872cd36638f24663f84b1c90e2890c3bf2ab527fab5ee8f3d565b57f5110f50ac78b8ff62e3fe1f373dbb84714720e5315ff0012e1e867b189e88cfcc2f2d5ddf4706ada6a93a8d8efc57edb229e438f8b46df128ca7b275b18138e7fdde4fc7fb267abc265ea8fd5144797bf30746bfb644bf992c6fd0526498f042c3a9566f8687f958f2caf57d93971cae03c487f0f0b2c3ab8c86fe992b6b7e7ef2f69d6ccd0dcc77b734fdd41030704ff94eb5551e390d376566c92dc1847f9d24e4d5422363c4529f21681a8497d71e65d594add5df236f1b0a101f767a7ec8a7c283f97fd8e65f6aeaa0203063fa61f57fc4ff00c53569711b33973281fcc89a283cd1a2cf29e314411e46a134559aa4d06fd32fec789960c80733ff0012d7ac359225927fcac5f277fd5c3fe48cff00f3466b7f92353fcdff00650ff8a72bf378fbfef4835ef3acdafc0fa37972d669a4b91c269caf1011ba81fca0f4677e39b0d2f668d39f17318c787e98fe3fdeb8f9752720e180e6ca7ca5e5e5d0b478ed090f70e4c972e3a19180141fe4a81c7355afd5f8f90cbf87947faae569f17046bab18fcc1b5bbd3b5dd3bccb6f1992180a25c01d8a31239780756e15cda764ce39314b013465f4fe3fa2e2eae2633130c9ec7ce5e58bc81664d4608aa2a639dd62707c08723f0cd5e5ececf0346323fd51c6e54751022ed8b79f3cd167aadb47a168cc6f6e6e655f50c5bad14d4283d1896a1dbe1cdaf65e8a58a472e5f44623f89c5d567131c11f512cd342d37f4768d6760c4334112a484742d4ab53db9139a5d566f132ca7fce2e6e2870c40602a2e7c89e65965789a4d0af8d03a0ad054951e1ce3a9dbf69337e7875d800bacd8ff1fe966ebf7c13fe8499b43e6ef2c4d0899753b6084568f22a3f4afd8621ff000cd1cb419c1ae097c9ce1a881176184f9bf5aff15dfda687a183711a49ea4b3d084e54e3cb7fd840cd56fdafd9ff002b79d9fa6fca425972fa4d7d3f8fe29383a8c9e291083d1ac2d23b3b2b7b48ff00bbb78d2253d2a1140afe19ce65c8672323fc4789d9463c200483f31ffe50fbdff5a2ff0093ab99fd8ffe331ff3bfdc971f59fdd957f21ffca23a77fa8dff00271b21da9fe313fc7f0b2d2ff7613fcd7b7bcce68aefc8de6492f12169741be346e1fb209a85f678cfd8afdb4ff85e9a328ebb0089359a1f8ff65fee9d690704eff824cd2dbcdfe58b8804c9a9dba29fd996458dc6d5fb0e55b34b3ecfcf134612ff00347139a351022ec314f36f9b0eb80797fcbcad7525c902e275042f106bc549a6dfceff00678e6db41a0f03f7d9bd1c3f4c7f1fec62e267cfc7e886f6cbfcb5a1c7a2e8f058290eeb569a41d1a46dd8fcbb2ff939a7d66a4e6c867fe97faae5e1c5c11a4d3315b5d8abb15762aec55d8abb157fffd0ee19e6ef46ec55d8abb15762aec55d8aa1ad74dd3ad1dded6d61b7797fbc68a3542ddfe22a057ae593cd398024652afe7163184472089cad93b1543de69da7deaaade5b4572a86a8264590027c39034cb31e69c3e9263fd53c2c65012e62d5c000000500d80195b26f1542c3a5e9905cbdd43690c573257d49d234591b91ab5580e46a7ae5b2cf394784ca463fcdbf4b110883606e8aca99253a97953cbba94864bcb18e495b76916b1b9f9b21563997875d9b18a8c8d7fa6ff74d53c109730b2c3c9de59b0904b6da7c62406aaefca520fb190b53e8c965ed0cf9054a46bfd2ff00b94434f08f209ce6137216f34ad2ef5d5ef2ce0b97514569a349081d680b0396e3cf921b46528ff54f0b19638cb98050ff00e1af2e7fd5aacffe91e2ff009a72cfce66fe7cff00d3498f830fe6c7e48e82dedede3f4e089228c7ec22851e1d065129991b26d98007254c8a56c91a488c92287461465615041ec41c20906c2916914fe42f28cf2191f4e40c7b46f246be3f65195733e3daba888a13ff00732ff741a0e9719e88fd33cbda2e97bd859c703d286402af4f0e6d56fc731f3eaf2e5fae464ce18a31e4130cc76c539e082e2268678d6589c51e3750ca47b83b64a3331360d15201d8a452fe5ff942472eda72827a8592541b6df655c0ccf8f6b6a40ae2fb23fa9c73a4c67a26fa7e97a769d118ac6da3b74635611a8153ee7a9fa730f2e79e4373264dd08463c8522b2a64a5736b6d750b41730a4f0b539452287534351556a8eb9284e513713c27c906208a2ddbdbdbdbc2b0dbc490c29b2471a8551df602806339991b26ca8000a0a9914ac9a186689a29916489c51e3701948f020ed86323136362a403cd229bc81e509a42efa72863d91e541ff028cab99f1ed5d4015c7f647f538e74b8cf44d34ed234bd350a58dac76e1bed145009f99ea7e9cc5cda8c990dcc9937431c63c852332964ec55d8abb15762aec55d8abb157fffd1ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd2ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd9, 30, 1);
INSERT INTO `producto` (`id_pro`, `id_cat`, `id_mar`, `id_mod`, `ser_pro`, `des_pro`, `pco_pro`, `pve_pro`, `img_pro`, `gar_pro`, `act_pro`) VALUES
(26, 20, 7, 4, '45215874936', 'Camara negra', '500.00', '250.00', 0xffd8ffe000104a46494600010101012b012b0000ffee000e41646f626500640000000001ffe10be44578696600004d4d002a000000080007011200030000000100010000011a00050000000100000062011b0005000000010000006a012800030000000100020000013100020000001f000000720132000200000014000000928769000400000001000000a6000000c6012bfff400010000012bfff40001000041646f62652050686f746f73686f702032322e32202857696e646f7773290000323032323a31313a32322031373a34323a3530000002a0020004000000010000015ea0030004000000010000015e0000000000000006010300030000000100060000011a00050000000100000114011b0005000000010000011c012800030000000100020000020100040000000100000124020200040000000100000ab80000000000000048000000010000004800000001ffd8ffed000c41646f62655f434d0001ffee000e41646f626500648000000001ffdb0084000c08080809080c09090c110b0a0b11150f0c0c0f1518131315131318110c0c0c0c0c0c110c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c010d0b0b0d0e0d100e0e10140e0e0e14140e0e0e0e14110c0c0c0c0c11110c0c0c0c0c0c110c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0cffc00011080054005403012200021101031101ffdd00040006ffc4013f0000010501010101010100000000000000030001020405060708090a0b0100010501010101010100000000000000010002030405060708090a0b1000010401030204020507060805030c33010002110304211231054151611322718132061491a1b14223241552c16233347282d14307259253f0e1f163733516a2b283264493546445c2a3743617d255e265f2b384c3d375e3f3462794a485b495c4d4e4f4a5b5c5d5e5f55666768696a6b6c6d6e6f637475767778797a7b7c7d7e7f711000202010204040304050607070605350100021103213112044151617122130532819114a1b14223c152d1f0332462e1728292435315637334f1250616a2b283072635c2d2449354a317644555367465e2f2b384c3d375e3f34694a485b495c4d4e4f4a5b5c5d5e5f55666768696a6b6c6d6e6f62737475767778797a7b7c7ffda000c03010002110311003f00ee12496767f5fe9d817fd9ed2f7dc002f656dddb6756ef712d6ee77ee2e6218e790f0c226477a8ba529088b91a74542db6aa2a7dd738575560b9ef3c001647fcede95fb97ff983ff0026b1bae75a77527b6aa43abc3ac8706bb473dffe92d03f73fc157ff5cff8bb38790cd3981389c71fd291ede1fd6629e7801713c45dbff9d7d23fe1bfedb3fde97fcebe91e377fdb67fbd72092d0ff4672ffd7ff187fdeb07de32787d8f7181d73a7750b8d18ef70b40dc1963769701f4b67ef6d57d79cb1efadedb2b71658c21cc7b796b870e0ba8c6fadd886867daebb1b911167a4d05848fcf64bdbf4ff73f3154e6be1d28107083389de3bca27fef59717300d89d0f1779258bff003b7a57ee5ffe60ff00c9ad6c6c9a32a866463bc5955825ae12383b4820fb9ae6bbe93553c9832e300ce12883a590cd1c91969120a44924944b9fffd0ee170bd55a5fd6f2980c17e46c04f6dc58c9fc5774b87ea3ff002fddff0086d9ff00555ac6f85ff3993fb9ff007516df33b47cdb591d0fa5e35cea323abb2ab591b98eae0891b87e7feea87ecae8bff97757f99ff99a87d64ff9772bfeb7ff0050c598afe18659e384ce79dce3191a8e1fd28f17f9b6bc8c412384686b793adfb2ba2ffe5dd5fe67fe6697ecae8bff0097757f99ff0099ac94949ed64ff3f3ff00170ffeaa47147f747db274f2fa3e2d5d3eccfc4cf6e65753db5bc359025c5ad8ddb9dee6ef6b957c5e95d4b32a3762e3badac12dde0b4091f487e91ec5731fff001299bff86ebfcb420f4d6e19a1c6feab6f4f7979fd0d7be0881167b0ed76e51c726410c9eae3943270094a0727a78612f9397e0fde5c446e3a5031bd0ffdfb532b0f2b0ed1565d469b0b7706920cb4e9ba585cdecba9faa9ff00247fd7acff00beae6ba88a0648f4331f9ed2c137581db8193fa2fd27d2fde5d2fd54ff00923febd67fdf543f1024f291277328dfa650fdefd09fae2bf057bba762ec24924b15b8ff00ffd1ee170fd47fe5fbbff0db3feaab5dc2e1fa8ffe282eff00c36cff00aaad637c2ff9cc9fdcff00ba8b6f99da3e6cfeb27fcbb97ff5bffa862cd5b7d7fa6f51bface4db4e2db6d4ed9b5ed6c830c6b4ff00d259ff00b23abffdc2bbfcdff6ad1e5f2e3183103388231c3f4a3fb8d79c4f14b43b9e8d4495bfd91d5ffee15dfe6ffb52fd91d5ff00ee15dfe6ff00b54bef62ff00390ff1a2b7865d8fd8dcc7ff00c4a66ffe1baff2d0aa74fe939fd4771c5ac1630c3ac7bb6b67f701f76e77f655ff00b2e4e37d56cc664d4fa5eec9adc1af104b6686ee50c5761f50e88ce956e5b306ea2d75b36ff37635c5eed7dd5eed9ea7d1dffe0d55190c63965020839e8ce8e58c21c10f5f0e3f9d90c6cc41fdcdbe5bd767372b13270ef763e530d76b4031c820fd17b1c3e931753f553fe48ffaf59ff7d587d77331f22dc6a31ec390cc3a7d27649ff08ef6cbb77e7edd9f4ff96b73eaa7fc91ff005eb3fefaa3e7a529727194c70c8ca3636fdee92fde5d80019686a28bb092492c66e3ffd2ee170fd7e8ba8ead92eb1a5adb9fead2f830e0437563ff00798e5dc2a79dd42dc5f51b553eb3d9536d63376ddce75a31c57f45dfbcb9fe4b34b164b8c44f8870f093c1b9fde6f678094459aa3dade3bf6cf54ffb9d7ff9e52fdb1d53fee75dfe715d97ed461caf4c47d98639c97e44f11b1fb3647fa0b7d5728b3a8defa580d21996fb7d0f44ba5ad7167da43acb037e8fd97f4bed6ff39fa1573ef83ff1247bfcd0dbbff36c3ed7fac3f6178ffdb1d53fee75dfe714bf6c754ffb9d77f9c575d6753b6a86bcd1b8dde89b7d4fd181e9d974bdaddf6d566eabd1f4acff003d48f5335d98adb363eac80fdf7d4e258cdaeae9a9dee1eeadf65cdaec7ff827ff00c1a5f7b1a7f4581bdbd51edc5fe6ff00e6a3daff005874f02f177751cdc867a791956db5c83b1ee2448fa26103737c577c73adfb236f6b00b1f70a431c4c026efb2ee7383777f2d0eeea76d2f14dadaabb7d46b0bdcf3e96c7b2db596eed9bfe963be9f4d3a1cf91623cb8144d88e488f97e6fd051c23acffe6bc2ee6f8aed3ead63dd474960b986b758f7d8d6b843b6b8fb3737f37746e5728cc7596d75cb1e2cadf6fa953896fb1ecab6b770ff008456156e739d96580c671f06bc5f371fcb71fdd8b2e1c2232e2e2be9b52924925419dfffd3ee102ec3aaeb3d5717076d63742222bb1b94dedfe919fe623aa9d4aa75d5d0c0c6d9fac564b5ed2e640ddad8d6fe62e631df10a3c3e2e8cf6dad63d2317696cbf638d9b84882db5f55afa4fb7f99db8d5e3b19ff0071bf469dfd3715af75acfd58cb1c0d7b58d6bd85fe9dcd6edd9ea39973e97eefe7a9fd1aabfb35cdcaa5bb297b5debd9b5d517515ee18cc6d75d7bbd9bbd3f53e97bff0058f628e3575d5f6739b5c50caed6b5b6309aebbfd577acd6b36bb652eaff0047d3dfff00717f47fe17f493d488046532bfd1afef74fd2fe698f4d8c29b87a6fe9bd7f5ed191b9aef50060d58db6a6b457e9fa7b7664d9f9a8bf646b9cd7dee75e4576547d40d8732d2c2f6bd95b18dff0005b56663d38cdb47db71dcea4d4f18ec7d4fb1cdacdf73e9a9a031efa9ff0067757b6afe76b67a7fb8a4c36e3d16b7303fd7bb06a60905ee7d8d6dec7d5b99bfd4bdbead7b92942566a5645463e900ca3f27eaebf4611f994243f777f16eb702aaf0eac26daf02b735f5bcb83ac2e63fd7066c6bbd5f7fd3f6247a7b770b45d67ae2c167afec2e2431f4359b4d7e8fa4daad7fb1b57fc22a62ac7ac5f5e6d2eb2f3e98a035a5d6398daea6d6cc3b9bfcdba9c86dbf42dafd1b3f58b3e9fa88b66101999b66352c65e719871ed0c022e272fdecb36ff39eeafd4ffa681045dccfabd56623867c7c1c5eafddf5fa95a7ee8d34dff75b0ec473ec6d9f6ab3d6a9aeadcf02a261e5b66d7b3d22cf6ecf6fb1595998edc537e1fd86a351a83864fb0b0b6b2c70f4725ce037dcec9f45fefdf67f3972d3516504100f6eb110947d457c35bd14924928d7bfffd4ee125f3924b9574dfa353899d2657ce2924a7e8ed7fbd213da7cd7ce2924a7e8e130638ee997ce4924a7e8e3302663b265f3924929fa3525f3924929ffd9ffe202404943435f50524f46494c450001010000023041444245021000006d6e74725247422058595a2007cf00060003000000000000616373704150504c000000006e6f6e65000000000000000000000000000000000000f6d6000100000000d32d4144424500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a63707274000000fc0000003264657363000001300000006b777470740000019c00000014626b7074000001b00000001472545243000001c40000000e67545243000001d40000000e62545243000001e40000000e7258595a000001f4000000146758595a00000208000000146258595a0000021c000000147465787400000000436f7079726967687420313939392041646f62652053797374656d7320496e636f72706f726174656400000064657363000000000000001141646f62652052474220283139393829000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000058595a20000000000000f35100010000000116cc58595a200000000000000000000000000000000063757276000000000000000102330000637572760000000000000001023300006375727600000000000000010233000058595a200000000000009c1800004fa5000004fc58595a20000000000000348d0000a02c00000f9558595a2000000000000026310000102f0000be9cffdb0043000604040405040605050609060506090b080606080b0c0a0a0b0a0a0c100c0c0c0c0c0c100c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0cffdb0043010707070d0c0d18101018140e0e0e14140e0e0e0e14110c0c0c0c0c11110c0c0c0c0c0c110c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0c0cffc0001108015e015e03011100021101031101ffc4001f0000000701010101010000000000000000040503020601000708090a0bffc400b51000020103030204020607030402060273010203110400052112314151061361227181143291a10715b14223c152d1e1331662f0247282f12543345392a2b26373c235442793a3b33617546474c3d2e2082683090a181984944546a4b456d355281af2e3f3c4d4e4f465758595a5b5c5d5e5f566768696a6b6c6d6e6f637475767778797a7b7c7d7e7f738485868788898a8b8c8d8e8f82939495969798999a9b9c9d9e9f92a3a4a5a6a7a8a9aaabacadaeafaffc4001f0100020203010101010100000000000000010002030405060708090a0bffc400b5110002020102030505040506040803036d0100021103042112314105511361220671819132a1b1f014c1d1e1234215526272f1332434438216925325a263b2c20773d235e2448317549308090a18192636451a2764745537f2a3b3c32829d3e3f38494a4b4c4d4e4f465758595a5b5c5d5e5f5465666768696a6b6c6d6e6f6475767778797a7b7c7d7e7f738485868788898a8b8c8d8e8f839495969798999a9b9c9d9e9f92a3a4a5a6a7a8a9aaabacadaeafaffdd0004002cffda000c03010002110311003f00ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd0ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd1ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1540eafade99a45b7d62fe611464d106e598f82a8dce5fa7d34f34b8602d864cb180b290ff00cacff2affbf26ff914733ff91351dd1f9b8ff9dc6eff00959fe55ff7e4dff228e3fc89a8ee8fcd7f3b8ddff2b3fcabfefc9bfe451c7f91351dd1f9afe771bbfe567f957fdf937fc8a38ff226a3ba3f35fcee377fcacff2affbf26ff91471fe44d47747e6bf9dc6eff959fe55ff007e4dff00228e3fc89a8ee8fcd7f3b8ddff002b3fcabfefc9bfe451c7f91351dd1f9afe771bbfe567f957fdf937fc8a38ff00226a3ba3f35fcee377fcacff002aff00bf26ff0091471fe44d47747e6bf9dc6e1f99de5424032ca2bdcc469f863fc8ba8ee1f35fcee364d67796b7b6c9736b2acd0482a922ee08cd664c72848c642a41ca8c8485856c825d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762afffd2ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8aa1356d56cf4bb096f6edf84310fa58f6551dd8e5d8304b2cc463ccb1c9311165e21e63f305e6b9a8b5ddc1e283e182107e18d3b01eff00cc73b8d1e923821c23fce97f39d1e6ca672b295665353b15762aec55d8abb15762aec55d8abb15651e48f384ba1ddfa1704be993b7ef53a98dba7a8bff001b0fdacd5f697678cf1b1fde47fd97f45cad36a380d1fa5ec914b14d124b13078a40191d4d41077041ce325120d1e6ee41b5f815d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157fffd3ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec554aeaeaded2da4b9b871141129691dba003270819c84622c944a400b2f15f3879aee35fbfa8ac7610922da13ff00136ff29bfe173b5ecfd08d3c3fa72faa4e97519ce43fd163f9b071dd8abb15762aec55d8abb15762aec55d8abb15762acdff002ffcea74e9574bd41ffd024348656ff7531ec7fe2b6ff85cd1f6b766f883c487d63eafe9ff00c79ced26a787d27e97ac0208a8e99c9bb5762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55fffd4ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762ad3ba2233b90a8a09663b0007524e102f60af1ff003df9c9f59b936566c46990b6c46deab8fdb3fe4ff20ff659d8765f677831e297f792ff0060e9f55a8e3343e96239b7711d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abd27f2efced5f4f45d4a4df65b29d8fdd131ff887fc0ff2e735dafd9bcf2c07f5e3feff00fe29d969353fc32ff35e8d9ce3b1762aec55d8abb15762aec55d8abb15762aec55d8abb15762afffd5ee19e6ef46ec55d8abb15762aec552ad47cd3e5ed39cc7797d1c728eb1825dc7cd5031199787439b20b8c4d354f3c23cca5fff002b17ca1ff2dc7fe454bff34e5ffc91a9fe6ffb28feb6bfcde3ef77fcac5f287fcb71ff009152ff00cd38ff00246a7f9bfeca3fad7f398fbddff2b17ca1ff002dc7fe454bff0034e3fc91a9fe6ffb28feb5fce63ef77fcac5f287fcb71ff9152ffcd38ff246a7f9bfeca3fad7f398fbddff002b17ca1ff2dc7fe454bff34e3fc91a9fe6ff00b28feb5fce63ef77fcac5f287fcb71ff009152ff00cd38ff00246a7f9bfeca3fad7f398fbd87f9efcf91ea51fe8ed2a43f52600dc4d42a64ff00200343c07ed7f366e7b2fb2ce33c7907aff863fcd70f55aae2f4c79305cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8ab60904106847438abd3bca9f99363fa3c5beb9318ee60a2a5c7167f517b72e20fc63bff3672fafec6971de217197f0ff0035d9e0d60aa9f34eff00e562f943fe5b8ffc8a97fe69cc1fe48d4ff37fd947f5b7fe731f7bbfe562f943fe5b8ffc8a97fe69c7f92353fcdff651fd6bf9cc7deeff00958be50ff96e3ff22a5ff9a71fe48d4ff37fd947f5afe731f7bbfe562f943fe5b8ff00c8a97fe69c7f92353fcdff00651fd6bf9cc7deeff958be50ff0096e3ff0022a5ff009a71fe48d4ff0037fd947f5afe731f7b63f317ca04d3ebdff24a5ff9a71fe48d4ff37fd947f5afe6f1f7a6da6ebba3ea40fd46ee39c8ea8adf10f9a9a37e19899b4b9317d71316e8658cb9147650cdd8abb15762aec55d8abfffd6ee19e6ef46ec55d8abb15762af36fcc1f3c5c25c49a3e97218c47f0dddc21a316ef1a9ed4fda39d2f64f6602064c82ff00991ff7ceb757a937c3179d1249a9dc9ea73a375cd62aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec555209e682559a0768a5435491090c0fb119194448511612091b87adf907ce4facc2d657a47e91817907e9eaa74e54fe65fdace47b57b3bc13c51feee5fec1dbe9751c628fd4cc334ee5bb15762aec55d8abfffd7ee19e6ef46ec55d8abb15436a5726d34ebaba1d60864947fb052dfc32cc30e3988ff003a422c672a892f9ee491e491a47259dc96663d4926a4e7a18000a0f3c4dadc2aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb154e3ca1752db799f4c78cd0bdc47137bacadc1bf06cc3ed080960983fcd32ff004bea6ed3caa63def77ce0ddebb15762aec55d8abffd0ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8aa65e5aff948f4aff98cb7ff0093ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157fffd1ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762af59f2f7e5be849a6412ea311babb9915deaccaabc8578a8523a789ce4b57db194cc881e18876d8b470e1f56e534ff00957be51ff9601ff2324ff9ab317f95b51fcefb22dbf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff957be51ff009601ff002324ff009ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff957be51ff009601ff002324ff009ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff957be51ff009601ff002324ff009ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff957be51ff009601ff002324ff009ab1fe56d47f3bec8afe531f73bfe55ef947fe5807fc8c93fe6ac7f95b51fcefb22bf94c7dceff00957be51ff9601ff2324ff9ab1fe56d47f3bec8afe531f725dae7e5ae812e9f2b69f11b5bb8d4b44c1d9958815e2c189d8fb66469bb673098e33c716bcba3811b6c5e479d7ba8762aec55d8abb15762aec55d8abb15762a99796bfe523d2bfe632dff00e4eae636b3fb99ff00525fee5b30fd71feb07bee700efdd8abb15762aec55fffd2ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f2091f997cefa7e817915adcc134af2c7ea868f8d29c8ad3e223f9733747d9b3d444ca240a3c3bb466d48c66884a3fe56de89ff002c773ff24ffe6acccfe40cbfce8ffb2fd4d3f9f8f7177fcadbd13fe58ee7fe49ff00cd58ff002065fe747fd97ea5fcfc7b8bbfe56de89ff2c773ff0024ff00e6ac7f9032ff003a3fecbf52fe7e3dc5dff2b6f44ff963b9ff00927ff3563fc8197f9d1ff65fa97f3f1ee2eff95b7a27fcb1dcff00c93ff9ab1fe40cbfce8ffb2fd4bf9f8f7177fcadbd13fe58ee7fe49ffcd58ff2065fe747fd97ea5fcfc7b8bbfe56de89ff002c773ff24ffe6ac7f9032ff3a3fecbf52fe7e3dc5dff002b6f44ff00963b9ff927ff003563fc8197f9d1ff0065fa97f3f1ee2eff0095b7a27fcb1dcffc93ff009ab1fe40cbfce8ff00b2fd4bf9f8f7177fcadbd13fe58ee7fe49ff00cd58ff002065fe747fd97ea5fcfc7b8bbfe56de89ff2c773ff0024ff00e6ac7f9032ff003a3fecbf52fe7e3dc5dff2b6f44ff963b9ff00927ff3563fc8197f9d1ff65fa97f3f1ee2eff95b7a27fcb1dcff00c93ff9ab1fe40cbfce8ffb2fd4bf9f8f7177fcadbd13fe58ee7fe49ffcd58ff2065fe747fd97ea5fcfc7b8bbfe56de89ff002c773ff24ffe6ac7f9032ff3a3fecbf52fe7e3dc5dff002b6f44ff00963b9ff927ff003563fc8197f9d1ff0065fa97f3f1ee29b796fcf5a76bd7cf676d6f344e91994b49c694040a7c24ff0036626b3b327821c52313bf0b6e1d50c86806433ff7127faa7f566be3cc392793e743d4e7a33ce358aa71e58f2ddd6bfa8fd561711468bce7988a855ad3a7727b661eb7591d3c388ee7f862dd8709c92a0ce47e516994defe6af7f853345fcbf3fe6c5cefc847bdbff9545a5ffcb7cfff000298ff002fe4fe6c57f211ef77fcaa2d2ffe5be7ff00814c7f97f27f362bf908f7a035afcaafab584b71a7ddb4d2c4a5cc12281c80152148fdacc8d376ef14c4671e107f89af26868582f3cce85d7bb15762a99796bfe523d2bfe632dffe4eae636b3fb99ff525fee5b30fd71feb07bee700efdd8abb15762aec55ffd3ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358ab26f22799adf42d4e47ba526d2e5024aca2a5483556a771e39aced4d11cf01c3f545c9d2e618e5bf22f4b1e7bf29115fd229bf8abffcd39ccff25ea3f987ec767f9ac7deeff1df94bfeae51ffc0bff00cd38ff0025ea3f987ec5fcd63ef77f8efca5ff005728ff00e05ffe69c7f92f51fcc3f62fe6b1f7a5fae7e63797edf4f97ea571f5bbb752b0c68ac0062280b16005066469bb2334a63887045af2eb2006c6cbc7b3b174eec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd4ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15762aec55d8abb15762aec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd5ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358ab22f24f96135fd4de299cc76b6ebea4c57ed1a9a0515e95f1cd77696b4e9e163ea97d2e469b0f892df93d147e5af9440ff00795cfbfab27f5ce73f96751dff00ec62ec7f278fb9dff2adbca3ff002cafff002364ff009ab1fe59d47f3bfd8c57f278fb9dff002adbca3ff2caff00f2364ff9ab1fe59d47f3bfd8c57f278fb901adfe58e88f612b69aaf6f771a968eaeceac40af160d5ebed991a6edaca2638fd516193451af4f3793e758ea5d8abb154cbcb5ff291e95ff3196fff00275731b59fdccffa92ff0072d987eb8ff583df738077eec55d8abb15762aff00ffd6ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358aa79e52f334be5fd48dc08fd68255e13c55a12b5a820ff32e60ebf443510e1ba90fa5bf066f0e56cf87e6c797a82b05c83e1c53fe6bcd07f20e6ef87dbfa9cffcfc3b8bbfe56c7977fdf173ff00009ff35e3fc859bbe1f6ff00c4afe7a1e6eff95b1e5dff007c5cff00c027fcd78ff2166ef87dbff12bf9e879a035afcd5b392c25874cb7945c4aa504b2f1509514e4002d53e197e9bb0a4260cc8e11fcd6bc9ae045446ef34ce99d6bb15762a99796bfe523d2bfe632dffe4eae636b3fb99ff525fee5b30fd71feb07bee700efdd8abb15762aec55ffd7ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15762aec55d8abb15762aec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd0ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15762aec55d8abb15762aec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd1ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15762aec55d8abb15762aec55d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd2ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abb15657e5bfcbcd5b578d6e67616566dba48e2aee3c5536dbfca6cd4eb3b5f1e13c23d7372f0e9253dcfa433183f2a7cb88804b2dc4afddb9aafe01734f2eddcc4ec221cc1a1879a0353fca4b46466d32f1e393b47380ca7db928047fc0b65f87b7e57eb8edfd16b9e807f0979feada3ea3a4ddb5adf4262946ebdd587f329e84674383510cb1e281b0ebf26330345059730762aec5532f2d7fca47a57fcc65bff00c9d5cc6d67f733fea4bfdcb661fae3fd60f7dce01dfbb15762aec55d8abfffd3ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358ab2ff00cbaf2c47ab6a2f77769cacace84a1e8f21dd54ff00923ed3669fb5f5a7143863f5cffd8c5ccd261e3959e517b00000a0d80ce3ddbb1cbffcc0f2bd94e607ba32c8a68fe8a97507fd61f0fdd9b1c5d959e62c0afeb38f3d5e389ab4d749d734bd5a03369f70b32aece0543293fcca68c33173e9b2623531c2db8f2c662c14379a3cbb6dae69725b48009d416b69bba3f6ff0062dd1b2dd16ae5832090fa7f8831cf844e34f0a9a192199e19578c91b14753d4329a119ddc64242c722e888ad966143b154cbcb5ff00291e95ff003196ff00f275731b59fdccff00a92ff72d987eb8ff00583df738077eec55d8abb15762afffd4ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abd93f2cadd22f2a42ea3e29e491dcfb86e1fa9738deda993a823f9a03b9d10ac6dfe646a97161e5b616ec524ba91602e3a856059a9f30bc70763e019336ffc038975933186dd5e359d9ba64e7ca1aadc69be60b396262164916199074649182907efa8cc2ed0c03261903d07147fcd6ed3ccc661eed9c23bd788f9fedd20f36dfaa6c1d924a7bba2b1fc4e76fd95332d3c6ff1bba4d50ac858f66c5c7762a99796bfe523d2bfe632dffe4eae636b3fb99ff525fee5b30fd71feb07bee700efdd8abb15762aec55ffd5ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358abd6bf2ab518e7d064b2afef6d253f0ff009127c40ffc172ce47b73098e612e931fee5db686770aee4f7cd7a08d6f4596c83049aa2481cf4122f4afb1fb3983a1d5781944ba7f17f55bf3e2e38d3c56ff0046d534fb8682eed648a4069ba9a1f7523661f2cedb16a31e417120874b3c7289a2194f90bc99a85cea506a57b0b41656cc2441202ad23aeeb4077e20ee5b355da9da308c0c2278a72dbfaae56974c4cb88f20f59ce49db3c1fcdba8a6a3e63beba8cf289a4e31b78ac60203f4f1cef34184e3c3189e75fee9d1679f14c94a3331a5d8aa65e5aff00948f4aff0098cb7ff93ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157ffd6ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f20f30fcdbff8ee5a7fcc28ff00938f9d3f607f752febff00bd0eaf5ff58f7306cdeb82ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1566bf94ff00f2914fff0030afff00134cd276f7f723faff00a24e6e83eb3ee7abcffdc49fea9fd59ca479876c793e743d4e7a33ce358aa6de59f30dc685aa25e4439c6470b886b4e687a8f98eab989add2473e3e13cff0085b70e53095bdb349d634fd5ad16eac6512c6df687ed29fe561fb27388cfa79e2970cc517778f2098b08dca59bb1560be7df3cdbda5b4ba5e9b2092f250527990d444a762011feec3ff0b9bdecaecc3390c931e81f4ff4ff00e3ae0eab5200e18f37956756ea9d8abb154cbcb5ff00291e95ff003196ff00f275731b59fdccff00a92ff72d987eb8ff00583df738077eec55d8abb15762afffd7ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762afa22c3fde1b7ff8c49ff1119e7797eb3ef7a28f2086d4340d1b519566beb48ee2545e0aee2a42d49a7e39662d565c62a12310c678a32dc842ff00833cadff0056c83fe072dfe51cff00cf930fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee0eff0006795bfead907fc0e3fca39ff9f25fcbe3ee08ad3fcbfa2e9d319ec6ce3b79994a174143c49048fc32acbabcb9054a464194314626c0464ffdc49feab7eaca63cc361e4f9d4f539e8cf38d62aec551361a8dfd84e27b29dede51fb4848a8f03e3f4e57970c320a90e20ca3331360b2387f33bcd51a056921948fda78c57fe14a8cd6cbb174e4f223e2e48d6e4416a7e79f336a28639af0c7136c638408c11ee57e23f7e5f87b33063362367fa5ea6b9ea672e6520ccf68762aec55d8aa65e5aff948f4aff98cb7ff0093ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157fffd0ee19e6ef46ec55d8abb154bbcc7ff28f6a9ff3093ffc9a6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762acef41fcd1b8b0b08acef6d3eb5e82848e657e0c546c03020d683be68755d88324cca32e1e2fe173f16b4c45116997fcadfb5ffab649ff002347fcd398dfe87e5fcf1fe95b3f940773bfe56fdaff00d5b24ff91a3fe69c7fd0fcbf9e3fd2aff280ee77fcadfb5ffab649ff002347fcd38ffa1f97f3c7fa55fe501dceff0095bf6bff0056c93fe468ff009a71ff0043f2fe78ff004abfca03b9dff2b7ed7fead927fc8d1ff34e3fe87e5fcf1fe957f940773bfe56fdaffd5b24ff0091a3fe69c7fd0fcbf9e3fd2aff00280ee77fcadfb5ff00ab649ff2347fcd38ff00a1f97f3c7fa55fe501dceff95bf6bff56c93fe468ff9a71ff43f2fe78ff4abfca03b9dff002b7ed7fead927fc8d1ff0034e3fe87e5fcf1fe957f940773bfe56fdaff00d5b24ff91a3fe69c7fd0fcbf9e3fd2aff280ee77fcadfb5ffab649ff002347fcd38ffa1f97f3c7fa55fe501dceff0095bf6bff0056c93fe468ff009a71ff0043f2fe78ff004abfca03b9dff2b7ed7fead927fc8d1ff34e3fe87e5fcf1fe957f940773bfe56fdaffd5b24ff0091a3fe69c7fd0fcbf9e3fd2aff00280ee77fcadfb5ff00ab649ff2347fcd38ff00a1f97f3c7fa55fe501dceff95bf6bff56c93fe468ff9a71ff43f2fe78ff4abfca03b9dff002b7ed7fead927fc8d1ff0034e3fe87e5fcf1fe957f940773bfe56fdaff00d5b24ff91a3fe69c7fd0fcbf9e3fd2aff280ee4bf5bfcd49ef2c64b5b1b4fab3cca51e777e4429d8f1000dfdf3234dd86213129cb8abf85af26b891405302cdfb80ec55d8abb15762aec55d8abb15762aec5532f2d7fca47a57fcc65bffc9d5cc6d67f733fea4bfdcb661fae3fd60f7dce01dfbb15762aec55d8abffd1ee19e6ef46ec55d8abb154bbcc5ff28fea7ff3093ffc9b6cc8d1ff007d0febc7fdd35e6fa0fb8bc073d01d03b15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8aa65e5aff948f4aff98cb7ff0093ab98dacfee67fd497fb96cc3f5c7fac1efb9c03bf762aec55d8abb157fffd2ee19e6ef46ec55d8abb1552bab74b9b59addfec4c8d1b7c98107f5e4a13e19090fe12890b14f9f6feca7b1bd9ad275e3340e51c7b83d7e9cf42c5904e2243949e7e51313450f9631762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8ab20f226992dff99ec8203c2d9c5ccadd8088861f7b715cd7f6a6618f04aff8bd1fe99c8d2c38a63c9edf9c3bbb762aec55d8abb157ffd3ee19e6ef46ec55d8abb15762ac47cede464d6ffd36ccac5a922d0f2d96551d031ecc3f65b36fd9bda6707a65be3ff70e26a74dc7b8fa9e55a868faa69d298ef6d6481877653c4fc9bec9fa33abc3a8c7905c4893aa9e39479841e5cc1d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8aa6ba3f95f5bd5a554b4b573193f14ee0ac6bf363fc331351adc5887a8ff009bfc4db8f04a7c83d7fca9e56b4f2fd898a33eadd4b4373714a7223a01e0abdb390d76ba5a89d9da23e98bb8c180631e69de60b73b15762aec55d8abffd4ee19e6ef46ec55d8abb15762aec55a6556146008f03be20aa9fd56dbfdf29ff02325c72ef470877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0877d56dbfdf29ff0231e3977af0877d56dbfdf29ff000231e3977af0870b6b61d224ff008118f1cbbd7842af4c8a5d8abb15762aec55d8abb157ffd5ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb1542ddeaba5d9b05bbbc82dd8f412c8884ff00c11196e3c1927f4c652fea86329c473202eb4d42c2f056d2e62b803a989d5c7fc293832629c3ea063fd60b1983c8da232b64ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55ffd6ee19e6ef46ec55d8abb15762ab65fee9ff00d53fab0c79a9e4f3cfc9ff00eeb55ff5a0fd526745ed07387f9dfef5d7767ff17c107f9a90493f9874e82315925855107bb4ac065dd87211c3227a4bfdeb0d70b980c8bf2c753375e5efaa39fded8486320f5e0df12feb65ff00639aeedac3c39b8872c81c9d14ee15fcd6593cd1c10493ca78c7129776f05515273531899100732e59342de0f2cd7379ab26a930a0bcbb623e619588f9287519de4631863f0c7f043f1fee5d0924cb88ff00117bde702ef985fe676a7247a5dbe936fbdcea5205e23a945236ff0064e5066ebb1708390e43f4e31f8ff62e1eb67e9111ce480fcbe9a7d1f5dd43cb576d56afa901dc02ca0569febc7c5bfd8e6476b4466c51cf1feacbf1fd1935e90984cc0bd0f39d760c2bcf3e68d421ba8341d1891a8dd15124abf69039a2aa9eccdd4b7ec2e6efb33450944e6cbfddc1c2d56720f047ea2bf4afcb1d1228b9ea85efeedc56562ee8818ee78f12ac7e6cd91cfdb5949ac7fbb8a61a288fabd454b59fcb7b28e26bcd01e5b2bf80738515d8ab103ec8624bab1ec7964f4ddb122787354e12e7b7e228c9a303787a648ef2079a26d6f4d923bb20df5990b2b814e6ad5e2d4fe6d983651daba218260c7e89b3d2e7338efcc317f33e996faa7e64456170ceb0ce88aed190185232db121876f0cda68b39c5a2331ce37fee9c5cd012cd453cff00954be5cff969bcff00838bfea9e60ff2f66ee87fb2ff008a6ffc843be5f8f83bfe552f973fe5a6f3fe0e2ffaa78ff2f66ee87fb2ff008a5fc843be5f8f8327d6405d12f947416d28ff009267357a6fef63fd68ff00ba72b27d27dcf22f24798e5d0b525966afe8dbb3e95c75a0229471ef1f2dff00c86cebfb4b4633c287f790f547fe27fce751a6cdc12fe897b52b2b28652195855586e083dc6714453ba79df9d7ff00260e81feb5b7fd449ce8bb37fc4f2ff9ff00f4cdd76a7fbe8fc3fdd3d1739c762ec55e43e53f2ae9fe60d53544bc9268c5bbf24f44aad793b035e4afe19d7ebf5d3d3e381881eafe77c1d460c03248db276fcaad2631cacafeeede7de921646a54782ac67fe1b3583b7721faa3090f8ffc79cafc8c7a1284b4d7f5ef2beb51695afcff005cd3ee29e8deb12594134e5c8fc440ff00762b7d9fd9ff002adc9a4c5aac472611c138fd50fc7fb1611cb3c52e199e28ff00399379e3fe513d4bfe317fc6c3359d99fe310f7b93a9feecb0cf28fe5fe8dace870dfdd4d729348ceacb13205f858a8a06463dbc7375da1dad970e530888d6df55ff00c5387a7d24670b369d7fcaa5f2e7fcb4de7fc1c5ff0054f30bf97b37743fd97fc5377e421df2fc7c139f2df9474df2fb5c359493486e4207f5995a9c2b4a7154fe6cc2d67684f515c423e9fe6ff6b7e1d3c71dd7562da8ff00e4d9b4ff00553fe4cb66d70ffc67cbf1fc4e24ff00c607e3a3d1739c762ec55d8abb15762aec55d8abb157ffd7ee19e6ef46ec55d8abb15762ab65fee9ff00d53fab0c79a9e4f3cfc9ff00eeb55ff5a0fd526745ed07387f9dfef5d7767ff17c16fe60ff00ca67a1ff00cf1ff93e70f64ff8b64ff3bfdc2eaffbd8fe3aabe8e3f41fe63ded81f86d754532423a0e46b22fdc7d58c657a8fdfe8a33fe2c5b1ff73ff112658fd1988e924dff0032354fa979665894d25bd6102f8f13f13ffc28e3fecb313b1f071e707a43d5ff0012dbac9f0c3facc33ccba57e8bb6f2bda11c650a5e61dfd477466afc89e39b9d1e7f1659a5d3f87fab5270f34384403d7339176cf3cb46ff0010fe644971f6ecb480447e1ca3345fbe52ce3fd5ce8b20fcbe880fe3cdfefbfe39e975f1fde66be906ff0031209b4bd6b4cf325b2ee8e239bc094f8941ff005d39a7fb1c1d91219714f04bfcdfc7f464bab0632130cf6dae61b9b68ae616e50cc8b246de2ac2a33413818c8c4f38b9f1208b0f3af2effa6fe686a53cbbb5b35c70affc56c205ff008539d1eafd1a1801fc5c1fecbf78ebb0fab393dd7ff12f4ace69d92025f306830caf14ba95ac72c64abc6f3c6acac362082d5073223a4ca45884c8feac981cb01d47cd4b4993cae6e241a43591b865e528b431732a0f56f4f7a54f7c96719e8789e270ff00b6717fbe638ce3bf4f0ff9ac0bccfa9dbe97f99115fdc2bb4302233ac6016358caec0951dfc737fa2c072e88c07395ff00ba70334c473594f3fe56d7973fe59af3fe022ffaa9983fc839bbe1fecbfe25bff3f0ee97e3e2af61f99ba0df5f5bd9c505d2cb7322c485d230a19cd05692134caf2f62e5840c898544717f17fc4b286b6122051dd90eb7ff001c6bff00f9869bfe4d9cd7e9bfbd8ff5a3f7b9197e93ee79d7937cbf0eb9e4fd46d1a8b3adcf3b694fecc8235a7d0df65b3a2ed1d59c1a98cba70fabfabc4ebb4f884f191e69cfe5d79827224f2eea554beb2aac01fa945d8a7ce3edfe47fab987dafa41b6687d13fabfe2bfce6ed2653f44b9c507e75ffc983a07fad6dff51272eecdff0013cbfe7ffd3361a9fefa3f0ff74f45ce71d8bb1579d7e57ffc7635bff597fe26f9d1f6dff778ff001d22ebb45f549e8b9ce3b160df9b76c8da25a5c53f7915c8407fc991189fc51737bd833232ca3df1ff00727fe3ce0ebc7a41f3466ad70f73f96a67735792ca22e7c5a8b5fc729c10e1d6d0ff005497e96790de0bfe8b1df28fe6068da36870d85d4372f346ceccd12a15f898b0a16753dfc3363da1d939736533898d6df55ffc4b8fa7d5c610a369d7fcadaf2e7fcb35e7fc045ff55330bf907377c3fd97fc4b77e7e1dd2fc7c591797bcc165aed8b5e5a2491c4b2188894286e4a01fd96614f8b35dabd24b04f865575c5e97271651905861ba8ff00e4d9b4ff00553fe4cb66e70ffc67cbf1fc4e14ff00c607e3a3d1739c762ec55d8abb15762aec55d8abb157ffd0ee19e6ef46ec55d8abb15762ab65fee9ff00d53fab0c79a9e4f3cfc9ff00eeb55ff5a0fd526745ed07387f9dfef5d7767ff17c16fe60ff00ca67a1ff00cf1ff93e70f64ff8b64ff3bfdc2eaffbd8fe3aa37f32eda5b57d335fb71fbeb2982391e04f34afb72561fecf28ec698971e13ca71fc7e3fa2cf5a2aa63f850dae5c45e63f3a68fa7c279d95bc6b752f851c094834fe6411aff00b2cb74b03a6d36499fae4783fde7fbae26394f89962072fa96fe687fc76344ff0059bfe26987b13fbbc9f8e9246b7ea8b30f34eadfa2b41bbbd0692aa7187fe323fc2bf713cb34fa1c1e2e58c7a7f17f55cccf938204b01f28797bcee9a77d7f48bdb7b38afbe26130e5230424026b149b75a7c59bfed0d5e94cf832465330fe6fd3feee2e069f0e5e1b89038bf1dc98eb1e59fcc6d42c24b7bed46d2e60fb6615501894dc71220535ff006598da7d6e8b1cc18427197f3bf191b3261cd214483f8feaa3bf2bb59fade8cfa7c8d59ac1a8a0f5f49ea57fe05b92ff00c0e51db7a7e0cbc63964ff0074cf4592e35fcd4a2d19745fcd19d673c21bf67e0e7a1fac7c6bff0025470cccc83c6d00ae78ff00e9dfa7fdc3547d19cdff0017fbe7a5e732ec920baf227956eee65b9b8b1e73cee6495fd5985598d49a070333e1da9a8844444b68ff00463ff12d12d2e326c8627e43b7b7b6f3f6b16d6cbc6de18ee2389412d4559e30054924e6dfb52665a484a5f548c7fdc49c4d28032c80f3ff0074ada8ff00e4d9b4ff00553fe4cb6430ff00c67cbf1fc499ff008c0fc747a2e738ec5d8aa0b5bff8e35fff00cc34dff26ce5fa6fef63fd68fdec32fd27dcc4bf28ff00e38d79ff00313ff32d736ddbff00dec7fabfa5c4d07d27deb3f30b43b8b6b887ccfa6552e6d994dd71f01b2c94f6fb0ffe4ffb2c9764eaa3207064fa65f4ff00c4ff00c4a3578883e2479849353d72df5bf36796afa1a06636cb3c7fc920b93c97fa7f9399b874a7069f2c0ff4f87fabe1b4cf289e481f77fba7ac6726ed5d8abcebf2bffe3b1adffacbff00137ce8fb6ffbbc7f8e9175da2faa4f45ce71d8bcfbf362fd5e0b0d262f8ee2597d631aee760513fe08b37fc0e743d838a8cb21fa40e1ff007d275faf96c229d798accd97e5fcd667ed5bda47131f74e20feacc2d264e3d6097f3a665f7b7e68f0e1af26bf2d7fe511b6ff5e5ff0093871ed9ff00183fe6ff00b9468ffbb0ca3356e53b1579d6a3ff009366d3fd54ff00932d9d1e1ff8cf97e3f89d74ff00c607e3a3d1739c762ec55d8abb15762aec55d8abb157ffd1ee19e6ef46ec55d8abb15762ab6404a301d4820611cd4b0dfcb7f2f6b1a326a0352b7f40ce62317c68f5e3cebf619bf9866e7b63578f318f01e2e1e2eff2fe7387a3c5285f106bce1e5dd6751f336957b676feadb5b7a7eb49cd178f19791d99831f87c061ecfd663c7827191a94af879ff351a8c3294e240d8324f31696354d12f2c69579a33e957fdf8bf127fc3019add267f0b2c67dc7fd8ff13939a1c51218c7e5df95353d267bbbcd521f4ae1d1618017473c3ab6e85bf95066cfb5f5f0ca231c66e3f549c5d26094093254f3e797b58d5752d2e6b0b7f5a3b62c666e68bc6aca7a3b2d7a76c8f65eaf1e284c4cf0997d3cfcd96ab14a52040e4bbf30746f306b26cac74f83959ab7a97131745018fc2bf0b32b1e0bc8f4fdac1d93a8c3878a533ebfe11457578e73a006ccb2ced61b4b486d61148a0458e31fe4a8a0cd4e4999c8c8f393971880282b6412c134ff002d6bba479e26beb2b6f5348ba6612b878d6892fc47e12c1bf7727f93f6737d97598b36944647f7b1f297f0ff00c545c18619c32d81e929df9bfca36fe60b54e2e20be82bf579fb6fd55a9fb3ff0011cc1ecfd79d3cbf9d097d516ed469c641e691daebfe7dd1e316ba8e8d26a823f863b88492cc0742cc8b257fd92ab7f36674f4ba4cc78a19062fe8cbfe3dc0d11cb961b4a3c4a926ade7dd707d5acf4dfd0d6f27c32dd4e4fa8abd0f1e411bc7ecc7fec97223069307aa53f1a5fcd8fd3fefbfdd24e4cb3d80e06bca1e4fd4743f34de4aca64d38dbb4705d164abb3346d42a0f21d1bf670f68768433e088ff29c5ea87fa65d3e9e50c87f9b4a3e63d0bcd5fe325d6b49b24b858953d3323c61490854d54ba377c9e8f55a7fcb785925c37e52effeac919b164f138a22d15fa57f353feacd67ff0006bff65195781a0ff549fe3fe49b2e3d47f363f8ff0039dfa57f353feacd67ff0006bff6518f81a0ff00549fe3fe49af1ea3f9b1fc7f9cc9aea3bcb9d0a68a48c0bd9ad595a252282578c82a09247da3fcd9ab818c72820fa233ff0063c4e548130f3a48bf2eb43d5348d32e60d460f425927e68bc91eabc00ad50b0ea333fb5f538f34c181e2023f8fa9a3498a5089126552471cb1b4722878dc157461504114208cd50241b0e5116f315fcbdd66c3cd96d3d9c1eae950dd4332cdea202b1890310559831283c07c59d39ed6c7934e448d6430946a8fd54eb3f2928e4047d36f50ce5dd9bb1579968fa479ff43bebd9ec34c865176db99a48cec18914e32a7f377ce9f51a8d2678444e64707f344bfe224eb31e3cd02481cff1de9b35efe6adc0f4c585a59d6bfbe0c869b781965ff886620c7a08efc539ff0047f10837716a0f403f1ef44f97fc8d2dbea3fa635bbafafea75e494a98d18746ab00588fd9f855532ad5f698943c3c43c3c7fec9962d2d4b8a478a49cf9aac6eafbcbd7d696a9ea5c4d1f18d2a16a7903d5881987a1cb1c79a3296d105bb3c4ca040e6c3f438ff0032b46d3a3b0b5d26d9e18cb32b4b2216f88f2352b3a8efe19b8d49d166999ca72bfe883ff54dc3c433c234223f1fe7261fa57f353feacd67ff0006bff65198fe0683fd527f8ff926d9c7a8fe6c7f1fe726be5dbcf394f752aebb6105a5b84ac4f0b024bd46c692c9dbdb313598f4d188f0a529cbfa5ff4841bb0cb213eb000fc79a41e63d0bcd5fe325d6b49b24b858953d3323c61490854d54ba377cd868f55a7fcb785925c37e52eff00eac9c7cd8b2789c51168afd2bf9a9ff566b3ff00835ffb28cabc0d07faa4ff001ff24d971ea3f9b1fc7f9c9a7976f7ceb3deba6b96105ada08c949216058c9c968bb4b26dc797ece62eaf1e9631bc5294e57fc5fcdff004906dc32ca4fac003f1e6c8735ce43b15762aec55d8abb157fffd2ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd3ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd4ee19e6ef46ec55d8abb15762aec55d8abceec7cebe78d4eeeea0d334fb4b8faab10f5aa103910bf6e65af4ed9d165ecdd2e288392538f17e3f98ebe3a9cb224440dbf1fce471d5ff0034d4166d1ad0a8dc80ca4d0785273947e5f41fea93fc7fc9367e267fe68fc7f9c8bf2d79e46a5a8be95a85a1b0d492bc632490c5772bb8055b8eff00e5653aceccf0e1e2425e263678753c478643864bfcf7e68d4340b6b496ce38a469dd95c4c19800a01db8b260ecbd0c351290913e9fe6aeab39c605201357fcd3750cba3d99560083c97a1ffa38cc83a7d00ff293fc7fc9361e267fe6c7f1fe7295d79a3f30f4d88dcea3a2c06d5013218892401dc95925e23e6b92868b4790f0c324b8bfa5ff0048c112cf9a3bca22bf1e6c9bcb7e62b3d7b4e1776e0c6ea784d031a947eb4af707f65b359acd1cb04f84ff009b27270e619058446b3acd8e8f60f7b78fc634d9546ecec7a2a8f1395e9b4f3cd3e18f365932080b2c3ed75bf3ff0098ab3e93143a6d8124453cc01240f7657e5fec63e39b89e9b49a7db219659ff363f88ffbb70e393364de3e98aebad43f323418cdd5f0b7d56cd3799a200145ff0062b130ff005b83ae0861d1673c30e2c52e9c5f89ff00ba594f363dcd4c328f2f7986c35db11756848653c6685bed46d4e87dbf95bf6b357abd24f04f865fe6cbf9ce5e2cc262c247e73f36eb3a3ea76563a74304cd76bb098313ccbf10010e807d399dd9da0c79b1ca73321c1fcdff00a464e3ea33ca120235ba97e95fcd4ffab359ff00c1affd9464fc0d07faa4ff001ff24d1c7a8fe6c7f1fe72d87f30ef2cae63b7f31e972587a9f66e12a53a0df891b81fe4bb619764c671270cc64fe8a8d5989a98e16690cd14f124d0b8922900647535041dc104669251313479b9a0dee18bddf9af5187cf10682b1c26ce50a5a42adea6f196d8f2e3d47f2e6d71e82074a72dcb887fa5fa9c596790cbc1d195e6a5ca4a7cd7ab5ce91a05d6a36ca8f341e9f059012a79c8a86a14a9e8de3997a1d3c73661097295ff00b96acf90c20486fcafaadc6ada0daea170a8934e1cbac60851c5d945012c7a2f8e0d6e018b2ca11e51fd4b82667004a55e68f3bfe8dbb5d2f4c83ebdab4941e90a9542454060bbb31fe51997a2ecdf123e2643e1e26acfa9e13c311c5240ad9fe6b4c9eb9beb5b62457eaa5509141d2a23906fff001932f393b3e26b8672fe96ff00f151ff0072d7c3a83bd81f8f72ed37cefaa58ea8ba4f9a2d96da590810dda6c86a680b6e4713fcebf67f697066ecdc73c7e2603c407d50fe24c35328cb8720a4ebcc977e6cb76b7fd03650dd860ff58331038914e34ac9175f8b30b478f4f2bf1a5287f3787fe919b7e696415c02d8e6a5e67fcc7d36cdef2f74bb38ada3a0792bca9c8851b2cecdd4e6cb0e8b45925c319ccc8fe3fd4dc69e7cd116446bf1fd25d61e64fccabfb48ef2d34ab396de604c6f50b500d3a34e0f51832e8f458e46329cc487e3fd4d619b3c8588c6bf1fd2649e5bbaf33cf1ce75eb386d1d4afa02120f206bcab4925f6cd6eb218224783233fe7717fd2307270cb21be31480f3579da2d2675d3ac61faeead2d02c22a550b7d9e5c7e22cdd9172fd0f669ca38e678310fe26bcfa9e03c23d524bd2d7f356e93d7fae5ad8f21b5bb2a123fe49cbff0013cc833d0436e19cff00a5f8943fdcb588ea0ef622b60f3b6b9a3ea11d8f9aad1638e4feeef611b53c7625587f371e2cbfcb865d9b8b340cf4f2b23f824a353281ac83fce6728e8e8ae8c19180656535041dc104668c820d173816f02bb15762aec55d8abb15762aff00ffd5ee19e6ef46ec55d8abb15762aec55d8abcebf2bffe3b1adffacbff00137ce8fb6ffbbc7f8e9175da2faa4f45ce71d8bcd3cd7c5bf32f4b169bce0db7afc7af21212797fcf2e3fec73a6d0ff88cf8b97af87fd2ff00c5badcff00df8af245fe6f7fbc3a77fc6593fe22329f67feb9fb832ed0e419ddaffbcd0ffa8bfab3433fa8b9f1e4ddccb6f15bcb25c32ac08a4cacdf64281bd7e8c61124811fa964401bbcf7f292297d5d5674056d58c68b5eec0b1ff8553ff0d9d0f6fc85407f16ff00a1d7e80733d1679d1db5af3b69fa11622da2282551e327c6e7fe4585a64bb34783a5965fe23fef7d31ff00668d4faf288747a3451470c49144a1238c05445140140a000673729126cf3764052f2010411507a8c0af34d2d7fc3df993269f07c1637bf088c740b22f34007f90ff0000ff00273a6ce7f31a2133f5c3fdefa65fec5d6c3f779a87292b7e60ff00ca5da0ff00ad1ffc9e190ec9ff0017c9f1ff00709d5ff791fc757a2e738ec52df316910eada3dcd948a199d0984f75900aa30fa732749a838b2090f8ff0055af36313890c5ff0029f53927d2aeac2462df53915a2af6496a683fd92b1ff659b4edec223904c7f18ff70e2e8277123b909a8ffe4d9b4ff553fe4cb65d87fe33e5f8fe2613ff00181f8e8f45ce71d8b1bfcc5ff943b50ff9e3ff0027d3365d91fe331ff3bfdc49c7d5ff00767f1d54fc9972b6be43b6b961558219e523d92476fe192ed18716acc7f9d28c7ec8a34f2ac40fbd22fcaeb3fae5dea3ae5d7ef2e99f8239de8cf5790efe355199fdb7938230c51da3f8e171f451b26679bd1739c76290f9bbca91798ad6088cff005696072eb370f50f1228cb4e49d4f13d7f6733fb3f5e74f226b88487d37c2d1a8c1e201d137b1825b7b282de593d69218d6379a94e65401ca9534e5d7ae61e5909489038412dd11400483f31ff00e50fbdff005a2ff93ab9b0ec7ff198ff009dfee4b8facfeecabf90ff00e511d3bfd46ff938d90ed4ff00189fe3f859697fbb09cde5ca5ad9cf74ff006208de56f922963fab30b1c0ca4223f88f0b74a540979ffe59599d4350d475fbca49745f846c7b34956723c362aa3fc9ce83b6b278708e18ed1ff89fa5d7e8a3c44ccf37a36738ec524f3969116a9e5ebb85941962469addbb8923048a7fadf67fd96677676a0e2cd13d0fa65fd5934ea31f140a53f95faa4977e5f6b694966b290c684ffbed87251f41e4332bb6f00866e21fc63fd934e8a770afe6b31cd3b98ec55d8abb15762aec55d8abffd6ee19e6ef46ec55d8abb15762aec55d8abc87ca76be679f54d50683790da3abfefccc01e40bb71a56397df3afd7cf0471c3c6899ff3787e1fd283a8c11c864780d3283a3fe68bfc126b56aa8db332280c077a5205ff008966aff31a01cb1cff001ff251caf0f3ff00387e3fcd47796bc8d069578da95e5cb5fea6f53eb3d68a5bed11525998ff00331ca359da672c78223c3c7fcd67874c227889e2924ff9bdfef0e9dff1964ff888cccf67feb9fb834f68720af0f917cc4d0c6c3cd576a19410a04bb5474fefb212ed3c209fdcc3fd8ffd536434b3afae5f8ff398ff009a7cbfaee94619f56bdb8d5f48e603fef9d58126b460fea05e54ea3361a1d5e2cb631c63872ff547fbde071f3e29c3791338bd1fcbaba40d1ad9b48411d83af289475dfaf2ad4f3aecd9cdeace4f14f89f5bb2c3c3c2387e960f7d5b6fcdc865936599a3e07c795bfa43fe1866f317abb3881fc37feef8dc196da8fc7f35e959cd3b2762af35d66971f9ab651c5bb44d0f3a7f90a643ff000b9d2e9fd3a0913d78bfe25d6e4df50157f307fe52ed07fd68ff00e4f0c8f64ff8be4f8ffb84eaff00bc8fe3abd1739c762b26952185e590d12352ee7c028a9c31892687552685bceff286272faacf4a21f4947857e327eece8fb7e5b407f5bfdebaed00e6576a429f9b1664ec0aa53fe4530c187fe33e5f8fe259ff008c07a2e738ec58dfe62ffca1da87fcf1ff0093e99b2ec8ff00198ff9dfee24e3eaff00bb3f8ea83f2f44d2fe591897ed496774aa3dd8c8065dab956baffa70ff007ad7885e0ff36484fca3950e8d7b103f1adcf223d99140ff00889cb7b7e3fbd89fe8fe963a03e93ef6779a2739d8abb15633f98fff00287deffad17fc9d5cd9f63ff008cc7fceff725c6d67f7655fc87ff00288e9dfea37fc9c6c876a7f8c4ff001fc2cb4bfdd84c35f89e6d0b5185055e4b599147bb46c06636964065813d271ff74d9945c08f2627f947321d1ef611f6d2e3991ece8a07fc40e6dfb7e3fbc89fe8fe9713407d27decef342e7213569521d2af2573448e091989f0084e5b8224e4881fce0c721a89f730bfca289c69fa84a7ec3cc880fbaad4ffc4866efb7e5eb88f270b40362cff39f73dd8abb15762aec55d8abb157ffd7ee19e6ef46ec55d8abb15762aec55d8abcebf2bffe3b1adffacbff00137ce8fb6ffbbc7f8e9175da2faa4f45ce71d8bb1579ff00e6f7fbc3a77fc6593fe2233a0f67feb9fb83afed0e419ddaff00bcd0ff00a8bfab3433fa8b9f1e487d6b4d4d4b49bab07a52e2364527a06eaadfec5a872cd36638f24663f84b1c90e2890c3bf2ab527fab5ee8f3d565b57f5110f50ac78b8ff62e3fe1f373dbb84714720e5315ff0012e1e867b189e88cfcc2f2d5ddf4706ada6a93a8d8efc57edb229e438f8b46df128ca7b275b18138e7fdde4fc7fb267abc265ea8fd5144797bf30746bfb644bf992c6fd0526498f042c3a9566f8687f958f2caf57d93971cae03c487f0f0b2c3ab8c86fe992b6b7e7ef2f69d6ccd0dcc77b734fdd41030704ff94eb5551e390d376566c92dc1847f9d24e4d5422363c4529f21681a8497d71e65d594add5df236f1b0a101f767a7ec8a7c283f97fd8e65f6aeaa0203063fa61f57fc4ff00c53569711b33973281fcc89a283cd1a2cf29e314411e46a134559aa4d06fd32fec789960c80733ff0012d7ac359225927fcac5f277fd5c3fe48cff00f3466b7f92353fcdff00650ff8a72bf378fbfef4835ef3acdafc0fa37972d669a4b91c269caf1011ba81fca0f4677e39b0d2f668d39f17318c787e98fe3fdeb8f9752720e180e6ca7ca5e5e5d0b478ed090f70e4c972e3a19180141fe4a81c7355afd5f8f90cbf87947faae569f17046bab18fcc1b5bbd3b5dd3bccb6f1992180a25c01d8a31239780756e15cda764ce39314b013465f4fe3fa2e2eae2633130c9ec7ce5e58bc81664d4608aa2a639dd62707c08723f0cd5e5ececf0346323fd51c6e54751022ed8b79f3cd167aadb47a168cc6f6e6e655f50c5bad14d4283d1896a1dbe1cdaf65e8a58a472e5f44623f89c5d567131c11f512cd342d37f4768d6760c4334112a484742d4ab53db9139a5d566f132ca7fce2e6e2870c40602a2e7c89e65965789a4d0af8d03a0ad054951e1ce3a9dbf69337e7875d800bacd8ff1fe966ebf7c13fe8499b43e6ef2c4d0899753b6084568f22a3f4afd8621ff000cd1cb419c1ae097c9ce1a881176184f9bf5aff15dfda687a183711a49ea4b3d084e54e3cb7fd840cd56fdafd9ff002b79d9fa6fca425972fa4d7d3f8fe29383a8c9e291083d1ac2d23b3b2b7b48ff00bbb78d2253d2a1140afe19ce65c8672323fc4789d9463c200483f31ffe50fbdff5a2ff0093ab99fd8ffe331ff3bfdc971f59fdd957f21ffca23a77fa8dff00271b21da9fe313fc7f0b2d2ff7613fcd7b7bcce68aefc8de6492f12169741be346e1fb209a85f678cfd8afdb4ff85e9a328ebb0089359a1f8ff65fee9d690704eff824cd2dbcdfe58b8804c9a9dba29fd996458dc6d5fb0e55b34b3ecfcf134612ff00347139a351022ec314f36f9b0eb80797fcbcad7525c902e275042f106bc549a6dfceff00678e6db41a0f03f7d9bd1c3f4c7f1fec62e267cfc7e886f6cbfcb5a1c7a2e8f058290eeb569a41d1a46dd8fcbb2ff939a7d66a4e6c867fe97faae5e1c5c11a4d3315b5d8abb15762aec55d8abb157fffd0ee19e6ef46ec55d8abb15762aec55d8aa1ad74dd3ad1dded6d61b7797fbc68a3542ddfe22a057ae593cd398024652afe7163184472089cad93b1543de69da7deaaade5b4572a86a8264590027c39034cb31e69c3e9263fd53c2c65012e62d5c000000500d80195b26f1542c3a5e9905cbdd43690c573257d49d234591b91ab5580e46a7ae5b2cf394784ca463fcdbf4b110883606e8aca99253a97953cbba94864bcb18e495b76916b1b9f9b21563997875d9b18a8c8d7fa6ff74d53c109730b2c3c9de59b0904b6da7c62406aaefca520fb190b53e8c965ed0cf9054a46bfd2ff00b94434f08f209ce6137216f34ad2ef5d5ef2ce0b97514569a349081d680b0396e3cf921b46528ff54f0b19638cb98050ff00e1af2e7fd5aacffe91e2ff009a72cfce66fe7cff00d3498f830fe6c7e48e82dedede3f4e089228c7ec22851e1d065129991b26d98007254c8a56c91a488c92287461465615041ec41c20906c2916914fe42f28cf2191f4e40c7b46f246be3f65195733e3daba888a13ff00732ff741a0e9719e88fd33cbda2e97bd859c703d286402af4f0e6d56fc731f3eaf2e5fae464ce18a31e4130cc76c539e082e2268678d6589c51e3750ca47b83b64a3331360d15201d8a452fe5ff942472eda72827a8592541b6df655c0ccf8f6b6a40ae2fb23fa9c73a4c67a26fa7e97a769d118ac6da3b74635611a8153ee7a9fa730f2e79e4373264dd08463c8522b2a64a5736b6d750b41730a4f0b539452287534351556a8eb9284e513713c27c906208a2ddbdbdbdbc2b0dbc490c29b2471a8551df602806339991b26ca8000a0a9914ac9a186689a29916489c51e3701948f020ed86323136362a403cd229bc81e509a42efa72863d91e541ff028cab99f1ed5d4015c7f647f538e74b8cf44d34ed234bd350a58dac76e1bed145009f99ea7e9cc5cda8c990dcc9937431c63c852332964ec55d8abb15762aec55d8abb157fffd1ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd2ee19e6ef46ec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb15762aec55d8abb157ffd9, 7, 1);

-- --------------------------------------------------------

--
-- Table structure for table `proveedor`
--

CREATE TABLE `proveedor` (
  `id_prv` int(15) NOT NULL,
  `doc_prv` varchar(10) COLLATE utf8_spanish_ci NOT NULL,
  `raz_prv` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `dir_prv` varchar(500) COLLATE utf8_spanish_ci NOT NULL,
  `tel_prv` varchar(15) COLLATE utf8_spanish_ci NOT NULL,
  `cor_prv` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `act_prv` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `proveedor`
--

INSERT INTO `proveedor` (`id_prv`, `doc_prv`, `raz_prv`, `dir_prv`, `tel_prv`, `cor_prv`, `act_prv`) VALUES
(34, 'V13509897', 'Noraida Arrieche', 'Las Casitas', '04167510937', 'noraidaarrieche2@gmail.com', 1),
(35, 'V7589621', 'Ramon DIaz', 'El tocuyo', '04126598745', 'Ramon460@gmail.com', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tasa_cambio`
--

CREATE TABLE `tasa_cambio` (
  `id_tca` int(15) NOT NULL,
  `id_mon` int(15) NOT NULL,
  `des_tca` varchar(200) COLLATE utf8_spanish_ci NOT NULL,
  `val_tca` decimal(10,2) NOT NULL,
  `act_tca` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `tasa_cambio`
--

INSERT INTO `tasa_cambio` (`id_tca`, `id_mon`, `des_tca`, `val_tca`, `act_tca`) VALUES
(4, 4, 'ESTÁNDAR', '1.00', 1),
(5, 4, 'ESPECIAL', '2.00', 1),
(6, 5, 'PARALELO', '12.60', 1),
(7, 5, 'BANCO CENTRAL DE VENEZUEL', '9.83', 1),
(8, 6, 'LU', '12.00', 1),
(9, 7, 'PARALELO BRASIL', '20.00', 1),
(10, 8, 'BBC', '5.00', 1);

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `id_usu` int(15) NOT NULL,
  `usr_usu` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `pas_usu` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `nom_usu` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `doc_usu` varchar(10) COLLATE utf8_spanish_ci NOT NULL,
  `cor_usu` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `niv_usu` int(1) NOT NULL,
  `act_usu` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`id_usu`, `usr_usu`, `pas_usu`, `nom_usu`, `doc_usu`, `cor_usu`, `niv_usu`, `act_usu`) VALUES
(8, '29561173', '29561173', 'Nelson Alejandro Pérez', 'V29561173', 'sagitario20120@gmail.com', 1, 1),
(15, '31195024', '31195024', 'Luisana Perez', 'V31195024', 'lu123@gmail.com', 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `vendedor`
--

CREATE TABLE `vendedor` (
  `id_ven` int(15) NOT NULL,
  `id_usu` int(15) NOT NULL,
  `act_ven` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Dumping data for table `vendedor`
--

INSERT INTO `vendedor` (`id_ven`, `id_usu`, `act_ven`) VALUES
(3, 8, 1),
(8, 15, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`id_bit`),
  ADD KEY `usuario` (`id_usu`);

--
-- Indexes for table `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id_cat`);

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cli`),
  ADD UNIQUE KEY `documento_identidad_4` (`doc_cli`),
  ADD KEY `documento_identidad` (`doc_cli`),
  ADD KEY `documento_identidad_2` (`doc_cli`),
  ADD KEY `documento_identidad_3` (`doc_cli`),
  ADD KEY `documento_identidad_5` (`doc_cli`);

--
-- Indexes for table `detalle_compra`
--
ALTER TABLE `detalle_compra`
  ADD PRIMARY KEY (`id_dco`),
  ADD KEY `compra` (`id_oco`),
  ADD KEY `producto` (`id_pro`);

--
-- Indexes for table `detalle_venta`
--
ALTER TABLE `detalle_venta`
  ADD PRIMARY KEY (`id_dve`),
  ADD KEY `venta` (`id_ove`),
  ADD KEY `producto` (`id_pro`),
  ADD KEY `venta_2` (`id_ove`);

--
-- Indexes for table `factura_venta`
--
ALTER TABLE `factura_venta`
  ADD PRIMARY KEY (`id_fve`),
  ADD KEY `cliente` (`id_ven`,`id_ove`,`id_mpa`),
  ADD KEY `metodo_pago` (`id_mpa`),
  ADD KEY `orden_venta` (`id_ove`),
  ADD KEY `imp_fve` (`id_imp`);

--
-- Indexes for table `garantia`
--
ALTER TABLE `garantia`
  ADD PRIMARY KEY (`id_gar`),
  ADD KEY `id_pro` (`id_dve`);

--
-- Indexes for table `impuesto`
--
ALTER TABLE `impuesto`
  ADD PRIMARY KEY (`id_imp`);

--
-- Indexes for table `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`id_mar`);

--
-- Indexes for table `metodo_pago`
--
ALTER TABLE `metodo_pago`
  ADD PRIMARY KEY (`id_mpa`);

--
-- Indexes for table `modelo`
--
ALTER TABLE `modelo`
  ADD PRIMARY KEY (`id_mod`);

--
-- Indexes for table `moneda`
--
ALTER TABLE `moneda`
  ADD PRIMARY KEY (`id_mon`);

--
-- Indexes for table `orden_compra`
--
ALTER TABLE `orden_compra`
  ADD PRIMARY KEY (`id_oco`),
  ADD KEY `proveedor` (`id_prv`),
  ADD KEY `id_mon` (`id_tca`);

--
-- Indexes for table `orden_venta`
--
ALTER TABLE `orden_venta`
  ADD PRIMARY KEY (`id_ove`),
  ADD KEY `cliente` (`id_cli`),
  ADD KEY `id_mon` (`id_tca`);

--
-- Indexes for table `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`id_pro`),
  ADD KEY `marca` (`id_mar`,`id_cat`),
  ADD KEY `categoria_2` (`id_cat`),
  ADD KEY `id_mod` (`id_mod`);

--
-- Indexes for table `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`id_prv`),
  ADD UNIQUE KEY `documento_identidad_3` (`doc_prv`),
  ADD KEY `documento_identidad` (`doc_prv`),
  ADD KEY `documento_identidad_2` (`doc_prv`);

--
-- Indexes for table `tasa_cambio`
--
ALTER TABLE `tasa_cambio`
  ADD PRIMARY KEY (`id_tca`),
  ADD KEY `id_mon` (`id_mon`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usu`),
  ADD UNIQUE KEY `user` (`usr_usu`);

--
-- Indexes for table `vendedor`
--
ALTER TABLE `vendedor`
  ADD PRIMARY KEY (`id_ven`),
  ADD KEY `id_user` (`id_usu`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `id_bit` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `categoria`
--
ALTER TABLE `categoria`
  MODIFY `id_cat` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cli` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `detalle_compra`
--
ALTER TABLE `detalle_compra`
  MODIFY `id_dco` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT for table `detalle_venta`
--
ALTER TABLE `detalle_venta`
  MODIFY `id_dve` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT for table `factura_venta`
--
ALTER TABLE `factura_venta`
  MODIFY `id_fve` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `garantia`
--
ALTER TABLE `garantia`
  MODIFY `id_gar` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `impuesto`
--
ALTER TABLE `impuesto`
  MODIFY `id_imp` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `marca`
--
ALTER TABLE `marca`
  MODIFY `id_mar` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `metodo_pago`
--
ALTER TABLE `metodo_pago`
  MODIFY `id_mpa` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `modelo`
--
ALTER TABLE `modelo`
  MODIFY `id_mod` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `moneda`
--
ALTER TABLE `moneda`
  MODIFY `id_mon` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `orden_compra`
--
ALTER TABLE `orden_compra`
  MODIFY `id_oco` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `orden_venta`
--
ALTER TABLE `orden_venta`
  MODIFY `id_ove` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `producto`
--
ALTER TABLE `producto`
  MODIFY `id_pro` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `id_prv` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `tasa_cambio`
--
ALTER TABLE `tasa_cambio`
  MODIFY `id_tca` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usu` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `vendedor`
--
ALTER TABLE `vendedor`
  MODIFY `id_ven` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bitacora`
--
ALTER TABLE `bitacora`
  ADD CONSTRAINT `bitacora_ibfk_1` FOREIGN KEY (`id_usu`) REFERENCES `usuario` (`id_usu`);

--
-- Constraints for table `detalle_compra`
--
ALTER TABLE `detalle_compra`
  ADD CONSTRAINT `detalle_compra_ibfk_1` FOREIGN KEY (`id_pro`) REFERENCES `producto` (`id_pro`),
  ADD CONSTRAINT `detalle_compra_ibfk_2` FOREIGN KEY (`id_oco`) REFERENCES `orden_compra` (`id_oco`);

--
-- Constraints for table `detalle_venta`
--
ALTER TABLE `detalle_venta`
  ADD CONSTRAINT `detalle_venta_ibfk_1` FOREIGN KEY (`id_pro`) REFERENCES `producto` (`id_pro`),
  ADD CONSTRAINT `detalle_venta_ibfk_2` FOREIGN KEY (`id_ove`) REFERENCES `orden_venta` (`id_ove`);

--
-- Constraints for table `factura_venta`
--
ALTER TABLE `factura_venta`
  ADD CONSTRAINT `factura_venta_ibfk_1` FOREIGN KEY (`id_mpa`) REFERENCES `metodo_pago` (`id_mpa`),
  ADD CONSTRAINT `factura_venta_ibfk_3` FOREIGN KEY (`id_ove`) REFERENCES `orden_venta` (`id_ove`),
  ADD CONSTRAINT `factura_venta_ibfk_4` FOREIGN KEY (`id_ven`) REFERENCES `vendedor` (`id_ven`),
  ADD CONSTRAINT `factura_venta_ibfk_5` FOREIGN KEY (`id_imp`) REFERENCES `impuesto` (`id_imp`);

--
-- Constraints for table `garantia`
--
ALTER TABLE `garantia`
  ADD CONSTRAINT `garantia_ibfk_1` FOREIGN KEY (`id_dve`) REFERENCES `detalle_venta` (`id_dve`);

--
-- Constraints for table `orden_compra`
--
ALTER TABLE `orden_compra`
  ADD CONSTRAINT `orden_compra_ibfk_1` FOREIGN KEY (`id_prv`) REFERENCES `proveedor` (`id_prv`),
  ADD CONSTRAINT `orden_compra_ibfk_2` FOREIGN KEY (`id_tca`) REFERENCES `tasa_cambio` (`id_tca`);

--
-- Constraints for table `orden_venta`
--
ALTER TABLE `orden_venta`
  ADD CONSTRAINT `orden_venta_ibfk_1` FOREIGN KEY (`id_cli`) REFERENCES `cliente` (`id_cli`),
  ADD CONSTRAINT `orden_venta_ibfk_2` FOREIGN KEY (`id_tca`) REFERENCES `tasa_cambio` (`id_tca`);

--
-- Constraints for table `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`id_cat`) REFERENCES `categoria` (`id_cat`),
  ADD CONSTRAINT `producto_ibfk_2` FOREIGN KEY (`id_mar`) REFERENCES `marca` (`id_mar`),
  ADD CONSTRAINT `producto_ibfk_3` FOREIGN KEY (`id_mod`) REFERENCES `modelo` (`id_mod`);

--
-- Constraints for table `tasa_cambio`
--
ALTER TABLE `tasa_cambio`
  ADD CONSTRAINT `tasa_cambio_ibfk_1` FOREIGN KEY (`id_mon`) REFERENCES `moneda` (`id_mon`);

--
-- Constraints for table `vendedor`
--
ALTER TABLE `vendedor`
  ADD CONSTRAINT `vendedor_ibfk_1` FOREIGN KEY (`id_usu`) REFERENCES `usuario` (`id_usu`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
