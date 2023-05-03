import 'bootstrap/dist/css/bootstrap.css';
import './styles/LoginPageStyle/Background.css';
import React, { Component } from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import Login from './components/Login.js';
import Banner from './components/Banner.js';
import Homepage from './Pages/Homepage.js';

const rootElement = document.getElementById('root');
const root = createRoot(rootElement);

root.render(
    <>
        <Router>
            <Banner />
            <Login />

            <Switch>
                <Route path="/Homepage" exact>
                    <Homepage />
                </Route>



            </Switch>
        </Router>
    </>
);
