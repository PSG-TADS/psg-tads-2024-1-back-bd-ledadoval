import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Login from './components/Login';
import Register from './components/Cadastro';
import Dashboard from './components/Dashboard';
import Veiculos from './components/Veiculos';
import Reservas from './components/Reservas';
import ClienteForm from './components/ClienteForm';
import './App.css';
import Cadastro from './components/Cadastro';

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/login" element={<Login />} />
        <Route path="/register" element={<Cadastro />} />
        <Route path="/dashboard" element={<Dashboard />} />
        <Route path="/veiculos" element={<Veiculos />} />
        <Route path="/reservas" element={<Reservas />} />
        <Route path="/clientes" element={<ClienteForm />} />
        <Route path="/" element={<Login />} />
      </Routes>
    </Router>
  );
}

export default App;
