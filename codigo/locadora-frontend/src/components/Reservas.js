import React, { useState, useEffect } from 'react';
import axios from 'axios';
import '../App.css';

const Reservas = () => {
  const [reservas, setReservas] = useState([]);
  const [idCliente, setIdCliente] = useState('');
  const [idVeiculo, setIdVeiculo] = useState('');
  const [dataComeco, setDataComeco] = useState('');
  const [dataFim, setDataFim] = useState('');
  const [vaiEstender, setVaiEstender] = useState(false);
  const [quantoTempo, setQuantoTempo] = useState(0);
  const [valorTotal, setValorTotal] = useState(0);

  useEffect(() => {
    axios.get('http://localhost:5000/api/reservas')
      .then(response => {
        setReservas(response.data);
      })
      .catch(error => {
        console.error('Houve um erro ao buscar as reservas:', error);
      });
  }, []);

  const handleSubmit = (e) => {
    e.preventDefault();
    axios.post('http://localhost:5000/api/reservas', { idCliente, idVeiculo, dataComeco, dataFim, vaiEstender, quantoTempo, valorTotal })
      .then(response => {
        alert('Reserva cadastrada com sucesso!');
        setReservas([...reservas, response.data]); // Atualizar a lista de reservas
      })
      .catch(error => {
        console.error('Houve um erro ao cadastrar a reserva:', error);
        alert('Erro ao cadastrar reserva. Tente novamente.');
      });
  };

  return (
    <div className="reservas">
      <h2>Reservas</h2>
      <form onSubmit={handleSubmit}>
          <label>ID Cliente</label>
        <input 
          type="number" 
          placeholder="ID Cliente" 
          value={idCliente} 
          onChange={e => setIdCliente(e.target.value)} 
          />
          <label>ID Veículo</label>
        <input 
          type="number" 
          placeholder="ID Veículo" 
          value={idVeiculo} 
          onChange={e => setIdVeiculo(e.target.value)} 
        />
          <label>Data de Inicio</label>
        <input 
          type="datetime-local" 
          placeholder="Data de Início" 
          value={dataComeco} 
          onChange={e => setDataComeco(e.target.value)} 
        />
        <label>Data Final</label>
        <input 
          type="datetime-local" 
          placeholder="Data de Fim" 
          value={dataFim} 
          onChange={e => setDataFim(e.target.value)} 
        />
        <label>
          Estender Locação
          <input 
            type="checkbox" 
            checked={vaiEstender} 
            onChange={e => setVaiEstender(e.target.checked)} 
          />
        </label>
        <button type="submit">Reservar</button>
      </form>
    </div>
  );
};

export default Reservas;
