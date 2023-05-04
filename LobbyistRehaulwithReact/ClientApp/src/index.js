import 'bootstrap/dist/css/bootstrap.css';
import './styles/LoginPageStyle/Background.css';
import React, { Component } from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";

import LoginPage from './Pages/LoginPage';
import Menu from './Pages/Menu';

const rootElement = document.getElementById('root');
const root = createRoot(rootElement);

root.render(
    <>
        <Router>
            <Routes>
                <Route path="/" element={<LoginPage />} />
                <Route path="/Homepage" element={<Menu />} />
            </Routes>
        </Router>
    </>
);
