//import { useState } from 'react'
//import reactLogo from './assets/react.svg'
//import viteLogo from '/vite.svg'
/*import { useEffect } from 'react';
import './App.css'

function App() {
    //const [forecasts, setForecasts] = useState([]);    useEffect(() => {        // Hämta data från API:et        fetch("/api/weatherforecast")            .then(resp => resp.json())            .then(data => setForecasts(data));    }, []);    return (        <>            {forecasts.map(forecast => (                <div key={forecast.date}>                    {forecast.date}, { forecast.temperatureC}                </div>            ))}        </>    )}

export default App
*/

import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Navbar from "./components/Navbar";
import ProductGrid from "./components/ProductGrid";
import Footer from "./components/Footer";
import ProductDetailPage from "./components/ProductDetailPage";

function App() {
    return (
        <Router>
            <div>
                <Navbar />
                <Routes>
                    <Route path="/" element={<ProductGrid products={[]} />} />
                    <Route path="/products/:id" element={<ProductDetailPage />} />
                </Routes>
                <Footer />
            </div>
        </Router>
    );
}

export default App;