import React, { useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';
import '../App.css';

const Cadastro = () => {
    const [nome, setNome] = useState('');
    const [email, setEmail] = useState('');
    const [senha, setSenha] = useState('');
    const [confirmSenha, setConfirmSenha] = useState('');
    const [mensagem, setMensagem] = useState('');
    const [loading, setLoading] = useState(false);
    const navigate = useNavigate();

    const handleCadastro = () => {
        // Verifica se as senhas são iguais
        if (senha !== confirmSenha) {
            setMensagem("Senhas não coincidem!");
            return;
        }

        setLoading(true);
        axios.post('http://localhost:5000/api/Cliente', { nome, email, senha })
            .then(response => {
                setMensagem("Cadastro realizado com sucesso!");
                navigate('/dashboard');
            })
            .catch(error => {
                setMensagem("Erro ao realizar o cadastro. Tente novamente.");
            })
            .finally(() => {
                setLoading(false);
            });
    };

    return (
        <div className="cadastro">
            <h2>LOCAVEICULOS</h2>
            <p>Faça seu cadastro!</p>
            <input
                type="text"
                placeholder="Nome"
                value={nome}
                onChange={e => setNome(e.target.value)}
                disabled={loading}
            />
            <input
                type="email"
                placeholder="Email"
                value={email}
                onChange={e => setEmail(e.target.value)}
                disabled={loading}
            />
            <input
                type="password"
                placeholder="Senha"
                value={senha}
                onChange={e => setSenha(e.target.value)}
                disabled={loading}
            />
            <input
                type="password"
                placeholder="Confirme a Senha"
                value={confirmSenha}
                onChange={e => setConfirmSenha(e.target.value)}
                disabled={loading}
            />
            <button onClick={handleCadastro} disabled={loading}>
                {loading ? 'Cadastrando...' : 'Cadastrar'}
            </button>
            <p>Já tem uma conta? <a href="/login">Faça login</a></p>
        </div>
    );
};

export default Cadastro;
