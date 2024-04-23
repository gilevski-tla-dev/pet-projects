import { FC } from 'react'

const FillStar: FC<{ fill: string; stroke: string }> = ({ fill, stroke }) => {
    return (
        <svg style={{ width: '100%', height: '100%' }} viewBox="0 0 30 31" xmlns="http://www.w3.org/2000/svg">
            <path d="M14.9312 -0.00867511L20.6385 8.35107L29.9312 14.4914L21.6889 20.4265L15.4311 30.4915L8.93112 20.4265L0.931121 14.4914L9.65139 7.84288L14.9312 -0.00867511Z" stroke={stroke} fill={fill} />
        </svg>
    )
}
export default FillStar
