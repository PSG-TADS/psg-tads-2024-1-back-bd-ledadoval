import React, { useState } from 'react';
import axios from 'axios';
import '../App.css';

const Login = () => {
    const [email, setEmail] = useState('');
    const [senha, setSenha] = useState('');
    const [error, setError] = useState('');

    const handleLogin = () => {
        setError('');

        // Verifica se os campos estão preenchidos
        if (!email || !senha) {
            setError('Por favor, preencha todos os campos.');
            return;
        }

        axios.post('http://localhost:5000/api/login', { email, senha })
            .then(response => {
                console.log(response.data);
            })
            .catch(error => {
                console.error(error);
                setError('Erro ao fazer login. Verifique suas credenciais.');
            });
    };

    return (
        <div className="login">
            <h2>LOCAVEICULOS</h2>
            <input
                type="email"
                placeholder="E-mail"
                value={email}
                onChange={e => setEmail(e.target.value)}
            />
            <input
                type="password"
                placeholder="Senha"
                value={senha}
                onChange={e => setSenha(e.target.value)}
            />
            <button onClick={handleLogin}>Entrar</button>
            {error && <div className="error">{error}</div>}
            <p>Não tem uma conta? <a href="/register">Cadastre-se</a></p>
        </div>
    );
};

export default Login;
