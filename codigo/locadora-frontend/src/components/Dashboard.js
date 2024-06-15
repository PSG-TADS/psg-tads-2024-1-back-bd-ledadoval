import React, { useState, useEffect } from 'react';
import axios from 'axios';
import '../App.css';
import { useNavigate } from 'react-router-dom';

const Dashboard = () => {
  const [clientes, setClientes] = useState([]);
  const [reservas, setReservas] = useState([]);
  const [veiculos, setVeiculos] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {
    // Consultar lista de clientes
    axios.get('http://localhost:5000/api/clientes')
      .then(response => {
        setClientes(response.data);
      })
      .catch(error => {
        console.error('Erro ao buscar clientes:', error);
      });

    // Consultar reservas ativas
    axios.get('http://localhost:5000/api/reservas')
      .then(response => {
        setReservas(response.data);
      })
      .catch(error => {
        console.error('Erro ao buscar reservas:', error);
      });

    // Consultar veículos cadastrados
    axios.get('http://localhost:5000/api/veiculos')
      .then(response => {
        setVeiculos(response.data);
      })
      .catch(error => {
        console.error('Erro ao buscar veículos:', error);
      });
  }, []);

  const handleLogout = () => {
    console.log('Usuário deslogado');
    navigate('/login');

  };

  return (
    <div className="dashboard">
      <button className="logout" onClick={handleLogout}>Sair</button>
      <div className="section">
        <h3>Lista de Clientes</h3>
        <ul>
          {clientes.map(cliente => (
            <li key={cliente.id}>{cliente.nome}</li>
          ))}
        </ul>
        <a href="/clientes">Ver mais</a>
      </div>
      <div className="section">
        <h3>Reservas Ativas</h3>
        <ul>
          {reservas.map(reserva => (
            <li key={reserva.idReserva}>
              Cliente: {reserva.idCliente} | Veículo: {reserva.idVeiculo}
            </li>
          ))}
        </ul>
        <a href="/reservas">Ver mais</a>
      </div>
      <div className="section">
        <h3>Veículos Cadastrados</h3>
        <ul>
          {veiculos.map(veiculo => (
            <li key={veiculo.id}>{veiculo.nome}</li>
          ))}
        </ul>
        <a href="/veiculos">Ver mais</a>
      </div>
    </div>
  );
};

export default Dashboard;
