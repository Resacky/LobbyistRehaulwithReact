import 'bootstrap/dist/css/bootstrap.css';
import React, { Component } from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter as Router, Routes, Route, Navigate } from "react-router-dom";

/* these are the pages, within React.js pages and components are the same thing */
import LoginPage from './pages/LoginPage';
import Menu from './pages/Menu';
import ViewPrincipals from './pages/Reports/ViewPrincipals';

/* everything that will be rendered will be rendered within the index.html beginning within the 'root' ID body element of the HTML code */
const rootElement = document.getElementById('root');
const root = createRoot(rootElement);

/* this is the main source of where everything is rendering and below you will see the different sort of Pages that can be rendered depending on the users URL */
root.render(
    <>
        <Router>
            <Routes>
                <Route path="/" element={<Navigate from="/" to="/LoginPage" />} />
                <Route path="/LoginPage" element={<LoginPage />} />
                <Route path="/Menu" element={<Menu />} />
                <Route path="/ViewPrincipals" element={<ViewPrincipals />} />
            </Routes>
        </Router>
    </>
);
