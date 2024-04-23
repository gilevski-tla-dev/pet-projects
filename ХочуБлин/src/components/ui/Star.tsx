import { FC } from 'react'

const Star: FC<{ stroke: string }> = ({ stroke }) => {
    return (
        <svg style={{ width: '100%', height: '100%' }} viewBox="0 0 35 35" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M34.286 17.4506C25.0731 17.4506 17.6045 9.98204 17.6045 0.769104" stroke={stroke} strokeWidth="2" />
            <path d="M17.6046 0.769642C17.6046 9.98258 10.136 17.4511 0.923096 17.4511" stroke={stroke} strokeWidth="2" />
            <path d="M1.02222 17.4511C10.235 17.5059 17.659 25.0187 17.6042 34.2315" stroke={stroke} strokeWidth="2" />
            <path d="M17.6041 34.2309C17.6589 25.0181 25.1717 17.5941 34.3845 17.6489" stroke={stroke} strokeWidth="2" />
        </svg>
    )
}
export default Star
