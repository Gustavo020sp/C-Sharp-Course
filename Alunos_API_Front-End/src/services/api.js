import axios from "axios";

const api = axios.create({
    baseURL : "https://localhost:44381",
})

export default api;