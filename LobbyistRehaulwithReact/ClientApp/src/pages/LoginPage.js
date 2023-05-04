import React from 'react';
import '../styles/LoginPageStyle/Background.css';

import Login from '../components/login';
import Banner from '../components/banner';

function LoginPage() {
    return (
        <>
            <body className="background">
                <Banner />
                <Login />
            </body>
        </>
    );
}

export default LoginPage;