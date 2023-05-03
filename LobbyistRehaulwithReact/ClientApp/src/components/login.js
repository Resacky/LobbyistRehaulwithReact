import React, { Component } from 'react';
import '../styles/LoginPageStyle/Login.css';

export class Login extends Component {
    static displayName = Login.name;

    render() {
        return (
            <>
                <div className="login-container">

                    <h2 className="Titletext">Login</h2>

                    <div className="form-group">
                        <label className="text" for="txtEmail">Email:</label>
                        <input type="text" className="form-control" id="txtEmail" name="txtEmail" placeholder="Enter Email" />
                    </div>

                    <div class="form-group">
                        <label className="text" for="txtPassword">Password:</label>
                        <input type="password" className="form-control" id="txtPassword" name="txtPassword" placeholder="Enter password" />
                    </div>

                    <div className="form-group">
                        <button type="submit" className="primary">Submit</button>
                    </div>

                    <div className="form-group">
                        <button type="New_User" className="secondary">New User?</button>
                        <button type="Forgot_Password" className="secondary">Forgot Password?</button>
                    </div>
                </div>
            </>
        );
    }
}
