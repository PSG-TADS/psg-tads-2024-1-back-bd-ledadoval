import React, { useState } from 'react';
import axios from 'axios';
import '../App.css'; 

const VeiculoCadastro = () => {
  const [placa, setPlaca] = useState('');
  const [modelo, setModelo] = useState('');
  const [marca, setMarca] = useState('');
  const [ano, setAno] = useState('');
  const [tipo, setTipo] = useState('');
  const [combustivel, setCombustivel] = useState('');
  const [situacao, setSituacao] = useState('');
  const [mensagem, setMensagem] = useState('');
  const [loading, setLoading] = useState(false);

  const handleCadastro = () => {
    setMensagem('');

    // Verifica se os campos estão preenchidos
    if (!placa || !modelo || !marca || !ano || !tipo || !combustivel || !situacao) {
      setMensagem("Por favor, preencha todos os campos.");
      return;
    }

    setLoading(true);
    axios.post('http://localhost:5000/api/veiculos', { placa, modelo, marca, ano, tipo, combustivel, situacao })
      .then(response => {
        setMensagem("Cadastro realizado com sucesso!");
        setPlaca('');
        setModelo('');
        setMarca('');
        setAno('');
        setTipo('');
        setCombustivel('');
        setSituacao('');
      })
      .catch(error => {
        setMensagem("Erro ao realizar o cadastro. Tente novamente.");
      })
      .finally(() => {
        setLoading(false);
      });
  };

  return (
    <div className="cadastro-veiculo">
      <h2>VEÍCULO</h2>
      {mensagem && <div className="mensagem">{mensagem}</div>}
      <input 
        type="text" 
        placeholder="Placa" 
        value={placa} 
        onChange={e => setPlaca(e.target.value)} 
        disabled={loading}
      />
      <input 
        type="text" 
        placeholder="Modelo Veículo" 
        value={modelo} 
        onChange={e => setModelo(e.target.value)} 
        disabled={loading}
      />
      <input 
        type="text" 
        placeholder="Marca" 
        value={marca} 
        onChange={e => setMarca(e.target.value)} 
        disabled={loading}
        className="full-width"
      />
      <input 
        type="text" 
        placeholder="Ano do Veículo" 
        value={ano} 
        onChange={e => setAno(e.target.value)} 
        disabled={loading}
      />
      <input 
        type="text" 
        placeholder="Tipo Veículo" 
        value={tipo} 
        onChange={e => setTipo(e.target.value)} 
        disabled={loading}
      />
      <input 
        type="text" 
        placeholder="Tipo de Combustível" 
        value={combustivel} 
        onChange={e => setCombustivel(e.target.value)} 
        disabled={loading}
      />
      <input 
        type="text" 
        placeholder="Situação Veículo" 
        value={situacao} 
        onChange={e => setSituacao(e.target.value)} 
        disabled={loading}
        className="full-width"
      />
      <button onClick={handleCadastro} disabled={loading}>
        {loading ? 'Salvando...' : 'Salvar'}
      </button>
    </div>
  );
};

export default VeiculoCadastro;
