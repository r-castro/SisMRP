CREATE DEFINER = CURRENT_USER TRIGGER `sysmrp`.`Trg_User_Inc` BEFORE INSERT ON `User` FOR EACH ROW
BEGIN
	DECLARE max_value CHAR(3);
    
    SELECT UserId FROM User ORDER BY UserId DESC LIMIT 1 INTO max_value;
    
    IF (max_value IS NULL) THEN
		SET NEW.UserId = 100;
	ELSE
		SET NEW.UserId = convert(max_value, SIGNED INTEGER);
	END IF;
END
