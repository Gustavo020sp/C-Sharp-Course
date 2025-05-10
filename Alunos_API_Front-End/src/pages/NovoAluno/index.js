import React, { useEffect, useState } from "react";
import './styles.css';
import { FiCornerDownLeft, FiUserPlus } from "react-icons/fi";
import { Link, useNavigate, useParams } from "react-router-dom";
import api from '../../services/api';
import { RiLoaderFill } from "react-icons/ri";

export default function NovoAluno() {

    const [id, setId] = useState(null);
    const [nome, setNome] = useState('');
    const [email, setEmail] = useState('');
    const [idade, setIdade] = useState(''); // Mantém idade como string

    const { alunoId } = useParams();
    const navigate = useNavigate();

    const token = localStorage.getItem('token');

    const authorization = {
        headers: {
            Authorization: `Bearer ${token}`
        }
    }

    useEffect(() => {
        if (alunoId !== '0') {
            loadAluno(alunoId);
        }
    }, [alunoId]); // Adiciona alunoId ao array de dependências
    
    async function loadAluno(id) { // Atualiza o parâmetro para ser `id`
        try {
            const response = await api.get(`/api/Alunos/${id}`, authorization);
            setId(response.data.id);
            setNome(response.data.nome);
            setEmail(response.data.email);
            setIdade(response.data.idade); // Mantém idade como string
        } catch (error) {
            alert('Erro ao recuperar o aluno: ' + error.message);
            navigate('/alunos');
        }
    }

    async function saveOrUpdate(event) {
        event.preventDefault(); // Previne o comportamento padrão do formulário

        const data = {
            nome,
            email,
            idade
        }

        try {
            if (alunoId === '0') {
                // Atualiza aluno existente
                await api.post('/api/alunos', data, authorization);
                
            } else {
                // Cria novo aluno
                data.id=id;
                await api.put(`/api/alunos/${id}`, data, authorization);
            }
            navigate('/alunos');
        } catch (error) {
            alert('Erro ao gravar aluno: ' + error.message);
        }
    }

    return (
        <div className="novo-aluno-container">
            <div className="content">
                <section className="form">
                    <FiUserPlus size="105" color="#17202a" />
                    <h1>{alunoId === '0' ? 'Incluir Novo Aluno' : 'Atualizar Aluno'}</h1>
                    <Link className="back-link" to="/alunos">
                        <FiCornerDownLeft size="25" color="#17202a" />
                        Retornar
                    </Link>
                </section>
                <form onSubmit={saveOrUpdate}>
                    <input
                        placeholder="Nome"
                        value={nome}
                        onChange={e => setNome(e.target.value)}
                    />
                    <input
                        placeholder="Email"
                        value={email}
                        onChange={e => setEmail(e.target.value)}
                    />
                    <input
                        placeholder="Idade"
                        value={idade}
                        onChange={e => setIdade(e.target.value)} // Mantém idade como string
                    />
                    <button className="button" type="submit">
                        {alunoId === '0' ? 'Incluir' : 'Atualizar'}
                    </button>
                </form>
            </div>
        </div>
    );
}
