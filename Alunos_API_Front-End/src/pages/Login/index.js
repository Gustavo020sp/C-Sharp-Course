import React, { useState } from 'react';
import './styles.css';
import logoImage from '../../assets/login.png'
import api from '../../services/api';
import { useNavigate } from 'react-router-dom';

export default function Login() {

    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const navigate = useNavigate();



    async function login(event) {
        event.preventDefault();

        const data = {
            email, password
        };

        try {
            const response = await api.post('api/account/loginuser', data)

            localStorage.setItem('email', email);
            localStorage.setItem('token', response.data.token);
            localStorage.setItem('expiration', response.data.expiration);
            navigate('/alunos');
        }
        catch (error) {
            alert('Falha no login' + error)
        }
    }



    return (
        <div className='login-container'>
            <section className='form'>
                <img src={logoImage} alt='Login' id='img1' />
                <form onSubmit={login}>
                    <h1>Cadastro de Alunos</h1>
                    <input placeholder='Email'
                        value={email}
                        onChange={e => setEmail(e.target.value)}
                    />

                    <input type='password' placeholder='Password'
                        value={password}
                        onChange={p => setPassword(p.target.value)}
                    />

                    <button class="button" type='submit'>Login</button>
                </form>
            </section>
        </div>
    )
}