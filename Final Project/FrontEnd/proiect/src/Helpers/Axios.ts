import axios from 'axios'

export default axios.create({
    baseURL: 'https://localhost:7271',
    withCredentials: true
})

export const login = async (email: string, password: string) => {
    try {
        const response = await axios.post('https://localhost:7271/api/User/Login', {
            email,
            password,
        });
        console.log(response.data);
    } catch (error) {
        console.error(error);
    }
};
