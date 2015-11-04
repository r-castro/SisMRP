CREATE FUNCTION `Get_UserAccess` (nameUser VARCHAR(45), passwdUser VARCHAR(32))
RETURNS BOOL
	BEGIN
		DECLARE statusUser BOOL;
		select count(*) from user where user.UserLogin = BINARY nameUser and user.UserPassword = md5(passwdUser) INTO statusUser;
        return statusUser;
    END