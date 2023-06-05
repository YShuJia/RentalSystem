/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : MySQL
 Source Server Version : 80028
 Source Host           : localhost:3306
 Source Schema         : rentalsystem

 Target Server Type    : MySQL
 Target Server Version : 80028
 File Encoding         : 65001

 Date: 08/06/2023 16:34:00
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for admin
-- ----------------------------
DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin`  (
  `a_id` char(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `a_pass` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `a_account` decimal(10, 2) UNSIGNED NULL DEFAULT 0.00,
  `a_tel` char(11) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`a_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of admin
-- ----------------------------
INSERT INTO `admin` VALUES ('A_789', 'qwe', 9720.00, '15955895661');

-- ----------------------------
-- Table structure for bill
-- ----------------------------
DROP TABLE IF EXISTS `bill`;
CREATE TABLE `bill`  (
  `b_id` char(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '时间戳',
  `h_id` bigint(12) UNSIGNED ZEROFILL NOT NULL,
  `u_id` char(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `b_day` int NULL DEFAULT NULL COMMENT '租赁时长',
  `b_stop_time` datetime NULL DEFAULT NULL COMMENT '结束时间',
  `b_rent` decimal(10, 2) UNSIGNED NOT NULL COMMENT '租金',
  `b_premium` decimal(10, 2) UNSIGNED NOT NULL COMMENT '手续费',
  `b_state` int NULL DEFAULT NULL COMMENT '0 取消 , 1完成，2待处理(房主), -2待处理(用户), -1删除, ，-3 退房申请，3订单正式完成',
  `b_deposit` decimal(10, 2) UNSIGNED NULL DEFAULT NULL COMMENT '押金',
  PRIMARY KEY (`b_id`, `h_id`, `u_id`) USING BTREE,
  INDEX `bill_house`(`h_id` ASC, `b_id` ASC, `u_id` ASC, `b_day` ASC, `b_stop_time` ASC) USING BTREE,
  INDEX `bill_users`(`u_id` ASC) USING BTREE,
  CONSTRAINT `bh` FOREIGN KEY (`h_id`) REFERENCES `house` (`h_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `bu` FOREIGN KEY (`u_id`) REFERENCES `users` (`u_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of bill
-- ----------------------------
INSERT INTO `bill` VALUES ('1686144391087', 000000001002, 'U_123', 15, '2023-06-22 21:43:58', 3300.00, 165.00, 3, 300.00);
INSERT INTO `bill` VALUES ('1686144493398', 000000001004, 'U_123', 180, '2023-12-04 22:11:16', 14600.00, 730.00, 3, 200.00);
INSERT INTO `bill` VALUES ('1686146950628', 000000001006, 'U_123', 365, '2024-06-06 22:11:35', 164650.00, 8232.50, 3, 400.00);
INSERT INTO `bill` VALUES ('1686146965777', 000000001008, 'U_123', 3, '2023-06-10 22:11:18', 2750.00, 137.50, 3, 800.00);
INSERT INTO `bill` VALUES ('1686148600740', 000000001003, 'U_123', 7, '2023-06-14 23:01:19', 4000.00, 200.00, 3, 500.00);
INSERT INTO `bill` VALUES ('1686150024638', 000000001005, 'U_123', 15, '2023-06-22 23:01:21', 3400.00, 170.00, 3, 400.00);
INSERT INTO `bill` VALUES ('1686150063314', 000000001007, 'U_123', 15, NULL, 11500.00, 575.00, 0, 1000.00);
INSERT INTO `bill` VALUES ('1686190986548', 000000001002, 'U_123', 7, '2023-06-15 10:57:28', 1700.00, 85.00, 1, 300.00);
INSERT INTO `bill` VALUES ('1686192974223', 000000001005, 'U_123', 7, NULL, 1800.00, 90.00, -2, 400.00);

-- ----------------------------
-- Table structure for complaints
-- ----------------------------
DROP TABLE IF EXISTS `complaints`;
CREATE TABLE `complaints`  (
  `c_id` char(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '时间戳 投诉',
  `c_content` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '投诉内容',
  `c_plaintiff` char(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '投诉者',
  `c_time` datetime NOT NULL COMMENT '时间',
  `c_something` char(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '对象',
  `c_result` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '结果',
  `c_state` int NULL DEFAULT 0 COMMENT '0 可查，1完成，-1 删除',
  `c_schedule` int NOT NULL COMMENT '-1用户处理，1房主处理，0管理员处理',
  `c_type` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '标志投诉人是用户还是房主',
  PRIMARY KEY (`c_id`, `c_plaintiff`, `c_something`) USING BTREE,
  INDEX `complaints`(`c_id` ASC, `c_state` ASC, `c_plaintiff` ASC, `c_something` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of complaints
-- ----------------------------
INSERT INTO `complaints` VALUES ('1686147104172', '房屋环境一点都不好', 'U_123', '2023-06-07 22:11:44', 'O_456', '积分扣除‘50’点', 1, 1, '用户');
INSERT INTO `complaints` VALUES ('1686193055173', '啊大苏打', 'U_123', '2023-06-08 10:57:35', 'O_456', '金额赔偿‘123’元', 0, -1, '用户');

-- ----------------------------
-- Table structure for house
-- ----------------------------
DROP TABLE IF EXISTS `house`;
CREATE TABLE `house`  (
  `h_id` bigint(12) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT,
  `o_id` char(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `h_type` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `h_area` decimal(10, 2) NULL DEFAULT NULL,
  `h_rent` decimal(10, 2) NULL DEFAULT NULL,
  `h_addr` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `h_introduce` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `h_state` int NULL DEFAULT 0 COMMENT '0在线，1预约，2出租，-1下架',
  `h_deposit` decimal(10, 2) NULL DEFAULT NULL COMMENT '押金',
  PRIMARY KEY (`h_id`) USING BTREE,
  INDEX `house_owner`(`o_id` ASC, `h_id` ASC, `h_area` ASC, `h_type` ASC) USING BTREE,
  CONSTRAINT `ho` FOREIGN KEY (`o_id`) REFERENCES `owner` (`o_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB AUTO_INCREMENT = 1009 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of house
-- ----------------------------
INSERT INTO `house` VALUES (000000001002, 'O_456', '三室一厅一卫', 120.00, 200.00, '毕节市七星关区麻园路', '舒适温馨的房子，采光好，在四楼站在阳台上可以看见小区里的小花园', 2, 300.00);
INSERT INTO `house` VALUES (000000001003, 'O_456', '四室两厅两卫', 300.00, 500.00, '毕节市金海湖', '小别墅，有独立阳台。', 1, 500.00);
INSERT INTO `house` VALUES (000000001004, 'O_456', '一室一厅', 100.00, 80.00, '贵阳市白云区', '三楼小套住房，适合两人居住', 1, 200.00);
INSERT INTO `house` VALUES (000000001005, 'O_456', '两室一厅一卫', 180.00, 200.00, '毕节市六小对面', '房屋很整洁，墙壁是一周前才装修过的', 2, 400.00);
INSERT INTO `house` VALUES (000000001006, 'O_456', '四室两厅两卫', 240.00, 480.00, '毕节市七星关区', '有阳台，房间都很整洁', 0, 450.00);
INSERT INTO `house` VALUES (000000001007, 'O_456', '六室两厅两卫', 500.00, 700.00, '毕节市学院路', '小型别墅', 0, 1000.00);
INSERT INTO `house` VALUES (000000001008, 'O_456', '五室两厅两卫', 423.00, 650.00, '贵阳市云岩区', '小型别墅，有花园', 0, 800.00);

-- ----------------------------
-- Table structure for owner
-- ----------------------------
DROP TABLE IF EXISTS `owner`;
CREATE TABLE `owner`  (
  `o_id` char(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `o_name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `o_pass` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `o_tel` char(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `o_sex` char(3) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `o_point` int UNSIGNED NULL DEFAULT 300,
  `o_account` decimal(10, 2) UNSIGNED NULL DEFAULT 0.00,
  `o_state` int NULL DEFAULT 0 COMMENT '0在线，1冻结，-1注销',
  PRIMARY KEY (`o_id`) USING BTREE,
  INDEX `owner`(`o_id` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of owner
-- ----------------------------
INSERT INTO `owner` VALUES ('O_456', '李四', 'qwe', '18485828048', '女', 373, 284980.00, 0);

-- ----------------------------
-- Table structure for reservation
-- ----------------------------
DROP TABLE IF EXISTS `reservation`;
CREATE TABLE `reservation`  (
  `r_id` char(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '时间戳 预约',
  `h_id` bigint(12) UNSIGNED ZEROFILL NOT NULL,
  `u_id` char(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `r_time` datetime NOT NULL,
  `r_state` int NULL DEFAULT NULL COMMENT '0 取消 , 1完成，2待处理(房主), -2待处理(用户), -1删除',
  PRIMARY KEY (`r_id`, `h_id`, `u_id`) USING BTREE,
  INDEX `users_index`(`u_id` ASC, `r_id` ASC, `h_id` ASC, `r_state` ASC) USING BTREE,
  INDEX `r_house`(`h_id` ASC) USING BTREE,
  CONSTRAINT `r_house` FOREIGN KEY (`h_id`) REFERENCES `house` (`h_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ru` FOREIGN KEY (`u_id`) REFERENCES `users` (`u_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of reservation
-- ----------------------------
INSERT INTO `reservation` VALUES ('1686144409162', 000000001003, 'U_123', '2023-06-09 00:00:00', 1);
INSERT INTO `reservation` VALUES ('1686144486406', 000000001005, 'U_123', '2023-06-10 00:00:00', 1);
INSERT INTO `reservation` VALUES ('1686146960603', 000000001007, 'U_123', '2023-06-09 00:00:00', 1);
INSERT INTO `reservation` VALUES ('1686149123951', 000000001002, 'U_123', '2023-06-07 00:00:00', 1);
INSERT INTO `reservation` VALUES ('1686150094496', 000000001002, 'U_123', '2023-06-07 00:00:00', 1);
INSERT INTO `reservation` VALUES ('1686191010001', 000000001003, 'U_123', '2023-06-08 00:00:00', -2);
INSERT INTO `reservation` VALUES ('1686192964291', 000000001004, 'U_123', '2023-06-09 00:00:00', -2);

-- ----------------------------
-- Table structure for transfer
-- ----------------------------
DROP TABLE IF EXISTS `transfer`;
CREATE TABLE `transfer`  (
  `t_id` char(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '转账id 时间戳',
  `t_object_id` char(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '转账人',
  `t_plaintiff_id` char(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '接收人',
  `t_amount` decimal(10, 2) NOT NULL COMMENT '金额',
  `t_time` datetime NOT NULL COMMENT '时间',
  `t_state` int NULL DEFAULT NULL COMMENT '(1，-1) 用户与房主，(2，-2)房主与管理，(3,-3)用户与管理，0删除',
  PRIMARY KEY (`t_id`, `t_object_id`, `t_plaintiff_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of transfer
-- ----------------------------
INSERT INTO `transfer` VALUES ('1686145438881', 'O_456', 'U_123', 3600.00, '2023-06-07 21:43:59', 1);
INSERT INTO `transfer` VALUES ('1686145438882', 'A_789', 'O_456', 165.00, '2023-06-07 21:43:59', 2);
INSERT INTO `transfer` VALUES ('1686147076183', 'A_789', 'O_456', 730.00, '2023-06-07 22:11:16', 2);
INSERT INTO `transfer` VALUES ('1686147076183', 'O_456', 'U_123', 14800.00, '2023-06-07 22:11:16', 1);
INSERT INTO `transfer` VALUES ('1686147078820', 'O_456', 'U_123', 3550.00, '2023-06-07 22:11:19', 1);
INSERT INTO `transfer` VALUES ('1686147078821', 'A_789', 'O_456', 137.50, '2023-06-07 22:11:19', 2);
INSERT INTO `transfer` VALUES ('1686147095489', 'A_789', 'O_456', 8232.50, '2023-06-07 22:11:35', 2);
INSERT INTO `transfer` VALUES ('1686147095489', 'O_456', 'U_123', 165050.00, '2023-06-07 22:11:35', 1);
INSERT INTO `transfer` VALUES ('1686147445820', 'U_123', 'O_456', 300.00, '2023-06-07 22:17:26', -1);
INSERT INTO `transfer` VALUES ('1686147449155', 'U_123', 'O_456', 200.00, '2023-06-07 22:17:29', -1);
INSERT INTO `transfer` VALUES ('1686147451827', 'U_123', 'O_456', 400.00, '2023-06-07 22:17:32', -1);
INSERT INTO `transfer` VALUES ('1686150079594', 'O_456', 'U_123', 4500.00, '2023-06-07 23:01:20', 1);
INSERT INTO `transfer` VALUES ('1686150079596', 'A_789', 'O_456', 200.00, '2023-06-07 23:01:20', 2);
INSERT INTO `transfer` VALUES ('1686150081834', 'O_456', 'U_123', 3800.00, '2023-06-07 23:01:22', 1);
INSERT INTO `transfer` VALUES ('1686150081835', 'A_789', 'O_456', 170.00, '2023-06-07 23:01:22', 2);
INSERT INTO `transfer` VALUES ('1686150330197', 'U_123', 'O_456', 800.00, '2023-06-07 23:05:30', -1);
INSERT INTO `transfer` VALUES ('1686150332973', 'U_123', 'O_456', 500.00, '2023-06-07 23:05:33', -1);
INSERT INTO `transfer` VALUES ('1686150335524', 'U_123', 'O_456', 400.00, '2023-06-07 23:05:36', -1);
INSERT INTO `transfer` VALUES ('1686193048109', 'O_456', 'U_123', 2000.00, '2023-06-08 10:57:28', 1);
INSERT INTO `transfer` VALUES ('1686193048112', 'A_789', 'O_456', 85.00, '2023-06-08 10:57:28', 2);

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users`  (
  `u_id` char(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `u_name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `u_pass` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `u_tel` char(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `u_sex` char(3) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `u_addr` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `u_point` int UNSIGNED NULL DEFAULT 300,
  `u_account` decimal(12, 2) UNSIGNED NULL DEFAULT 0.00,
  `u_state` int NULL DEFAULT 0,
  PRIMARY KEY (`u_id`) USING BTREE,
  INDEX `qwe`(`u_id` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES ('U_123', '张三', 'qwe', '15674561263', '男', '毕节', 300, 7632250.00, 0);

-- ----------------------------
-- View structure for bill_log
-- ----------------------------
DROP VIEW IF EXISTS `bill_log`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `bill_log` AS select `bill`.`b_id` AS `b_id`,`users`.`u_id` AS `u_id`,`users`.`u_name` AS `u_name`,`users`.`u_tel` AS `u_tel`,`bill`.`h_id` AS `h_id`,`house`.`h_type` AS `h_type`,`house`.`h_area` AS `h_area`,`house`.`h_addr` AS `h_addr`,`bill`.`b_day` AS `b_day`,`bill`.`b_stop_time` AS `b_stop_time`,`bill`.`b_rent` AS `b_rent`,`bill`.`b_deposit` AS `b_deposit`,`bill`.`b_premium` AS `b_premium`,`bill`.`b_state` AS `b_state` from ((`bill` join `house` on((`bill`.`h_id` = `house`.`h_id`))) join `users` on((`bill`.`u_id` = `users`.`u_id`)));

-- ----------------------------
-- View structure for owner_house
-- ----------------------------
DROP VIEW IF EXISTS `owner_house`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `owner_house` AS select `owner`.`o_id` AS `o_id`,`owner`.`o_sex` AS `o_sex`,`owner`.`o_name` AS `o_name`,`owner`.`o_tel` AS `o_tel`,`house`.`h_deposit` AS `h_deposit`,`house`.`h_id` AS `h_id`,`house`.`h_type` AS `h_type`,`house`.`h_area` AS `h_area`,`house`.`h_rent` AS `h_rent`,`house`.`h_addr` AS `h_addr`,`house`.`h_introduce` AS `h_introduce`,`house`.`h_state` AS `h_state` from (`owner` join `house` on((`owner`.`o_id` = `house`.`o_id`)));

-- ----------------------------
-- View structure for reservation_log
-- ----------------------------
DROP VIEW IF EXISTS `reservation_log`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `reservation_log` AS select `reservation`.`r_id` AS `r_id`,`users`.`u_id` AS `u_id`,`users`.`u_name` AS `u_name`,`users`.`u_tel` AS `u_tel`,`reservation`.`h_id` AS `h_id`,`house`.`h_type` AS `h_type`,`house`.`h_area` AS `h_area`,`house`.`h_addr` AS `h_addr`,`reservation`.`r_time` AS `r_time`,`reservation`.`r_state` AS `r_state` from ((`reservation` join `house` on((`reservation`.`h_id` = `house`.`h_id`))) join `users` on((`reservation`.`u_id` = `users`.`u_id`)));

SET FOREIGN_KEY_CHECKS = 1;
