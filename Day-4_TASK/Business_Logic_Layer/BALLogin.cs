﻿



namespace Business_Logic_Layer
{
    public class BALLogin
    {
        public DALLogin _dalLogin;

        public BALLogin(DALLogin dalLogin)
        {
            _dalLogin = dalLogin;
        }

        ResponseResult result = new ResponseResult();
        public ResponseResult LoginUser(User user)
        {
            try
            {
                User userObj = new User();
                userObj = UserLogin(user);
                if(userObj != null)
                {
                    if(userObj.Message.ToString() == "Login Successfully")
                    {
                        result.Message = userObj.Message;
                        result.Result = ResponseStatus.Success;
                        result.Data = userObj;
                    }
                    else
                    {
                        result.Message = userObj.Message;
                        result.Result = ResponseStatus.Error;
                    }
                }
                else
                {
                    result.Message = "Error in login";
                    result.Result = ResponseStatus.Success;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public User UserLogin(User user)
        {
            User userObj = new User()
            {
                EmailAddress = user.EmailAddress,
                Password = user.Password,
            };
            return _dalLogin.LoginUser(userObj); ;
        }
    }
}
