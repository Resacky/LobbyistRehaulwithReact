import 'bootstrap/dist/css/bootstrap.css';
import './styles/LoginPageStyle/Background.css';
import React, { Component } from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter } from 'react-router-dom';
import Login from './components/Login.js';
import Banner from './components/Banner.js';
import Homepage from './Pages/Homepage.js';

const rootElement = document.getElementById('root');
const root = createRoot(rootElement);

root.render(
    <BrowserRouter>
        <>
            <Banner />
            <Login />
        </>
    </BrowserRouter>
);
