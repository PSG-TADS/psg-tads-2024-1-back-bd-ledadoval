import React, { useState } from 'react';
import axios from 'axios';
import '../App.css';

const ClienteForm = () => {
  const [nome, setNome] = useState('');
  const [telefone, setTelefone] = useState('');
  const [endereco, setEndereco] = useState('');
  const [email, setEmail] = useState('');
  const [ehNovoCliente, setEhNovoCliente] = useState(true);
  const [quantLocados, setQuantLocados] = useState(0);

  const handleSubmit = (e) => {
    e.preventDefault();
    axios.post('http://localhost:5000/api/clientes', { nome, telefone, endereco, email, ehNovoCliente, quantLocados })
      .then(response => {
        // Lidar com resposta de sucesso
        alert('Cliente cadastrado com sucesso!');
      })
      .catch(error => {
        // Lidar com erro
        console.error('Houve um erro ao cadastrar o cliente:', error);
        alert('Erro ao cadastrar cliente. Tente novamente.');
      });
  };

  return (
    <div className="cliente-form">
      <h2>Cadastro de Cliente</h2>
      <form onSubmit={handleSubmit}>
        <input 
          type="text" 
          placeholder="Nome" 
          value={nome} 
          onChange={e => setNome(e.target.value)} 
        />
        <input 
          type="text" 
          placeholder="Telefone" 
          value={telefone} 
          onChange={e => setTelefone(e.target.value)} 
        />
        <input 
          type="text" 
          placeholder="Endereço" 
          value={endereco} 
          onChange={e => setEndereco(e.target.value)} 
        />
        <input 
          type="email" 
          placeholder="Email" 
          value={email} 
          onChange={e => setEmail(e.target.value)} 
        />
        <label>
          <input 
            type="checkbox" 
            checked={ehNovoCliente} 
            onChange={e => setEhNovoCliente(e.target.checked)} 
            />
            Novo Cliente
        </label>
        <button type="submit">Cadastrar</button>
      </form>
    </div>
  );
};

export default ClienteForm;
