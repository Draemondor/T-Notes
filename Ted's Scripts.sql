CREATE DEFINER=`root`@`localhost` TRIGGER `user_AFTER_DELETE` AFTER DELETE ON `user` FOR EACH ROW BEGIN
IF NEW.user_id > OLD.user_id THEN
	SET NEW.user_id = NEW.user_id - 1;
END IF;    
END