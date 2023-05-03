import "../styles/LoginPageStyle/Login.css";
import { Link } from "react-router-dom";

const linkStyleSubmit = {


}

function Login() {
    return (
        <>
            <div class="login-container">

                <h2 class="Titletext">Login</h2>

                <div class="form-group">
                    <label class="text" for="txtEmail">Email:</label>
                    <input type="text" class="form-control" id="txtEmail" name="txtEmail" placeholder="Enter Email" />
                </div>

                <div class="form-group">
                    <label class="text" for="txtPassword">Password:</label>
                    <input type="password" class="form-control" id="txtPassword" name="txtPassword" placeholder="Enter password" />
                </div>

                <div class="form-group">
                    <Link to="/Homepage" className="primary">Submit</Link>
                </div>

                <div class="form-group">
                    <Link to="/NewUser" className="secondary">New User?</Link>
                    <Link to="/ForgotPassword" className="secondary">Forgot Password?</Link>
                </div>
            </div>
        </>
    );
}

export default Login;