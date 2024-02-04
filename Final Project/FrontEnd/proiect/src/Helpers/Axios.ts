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
        var token = response.data.id;
        if(token){
            localStorage.setItem('MyToken', token);
        }
    } catch (error) {
        console.error(error);
    }
};

export const signUp = async(firstName:string, lastName:string,
                            phoneNumber:string, userName:string, email:string, password:string)=>{
    try {
        const response = await axios.post('https://localhost:7271/api/User/SignUp', {
            firstName,
            lastName,
            phoneNumber,
            userName,
            email,
            password,
        });
        console.log(response.data);
    }catch (error){
        console.error(error);
    }
};

export const foundUser = async (id:string)=>{
    try {
        const response = await axios.get(`https://localhost:7271/api/User/GetUserById?id=${id}`);
        return response.data;
    }catch (error){
        console.log(error);
    }
};

export const foundProfile = async (username:string) =>{
    try{
        const response = await axios.get(`https://localhost:7271/GetProfile?username=${username}`);
        return response.data;
    }catch (error){
        console.log(error);
    }
}

export const getPostsOfUser = async (username:string) =>{
    try{
        const response = await axios.get(`https://localhost:7271/GetPostsByUsername?username=${username}`);
        return response.data;
    }catch (error){
        console.log(error);
    }
}

export const getFeed = async () =>{
    try{
        const response = await axios.get(`https://localhost:7271/PostFeed`);
        return response.data;
    }catch (error){
        console.log(error);
    }
}