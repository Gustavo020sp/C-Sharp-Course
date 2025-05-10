import React from "react";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Login from './pages/Login/index.js';
import Alunos from './pages/Alunos';
import NovoAluno from './pages/NovoAluno';



export default function AppRoutes(){
    return(
        <BrowserRouter>
            <Routes>
                <Route path="/" exact element={<Login />}/>
                <Route path="/aluno/novo/:alunoId" element={<NovoAluno />}/>
                <Route path="/alunos" element={<Alunos />}/>                
            </Routes>
        </BrowserRouter>
    );
}